using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace PortChecker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        static async Task<bool> checkPortAsync(string host, int port)
        {
            using (var client = new TcpClient())
            {
                int timeoutMs = 5000; //adjust this if you want i guess
                try
                {
                  
                    Task connectTask = client.ConnectAsync(host, port);
                    Task timeoutTask = Task.Delay(timeoutMs);

                    Task completedTask = await Task.WhenAny(connectTask, timeoutTask);

                    if (completedTask == timeoutTask)
                    {
                      
                        return false; 
                    }

                 
                    await connectTask; 
                    return client.Connected; 
                }
                catch (SocketException ex)
                {
                    // Specific socket errors (e.g., connection refused)
                    // For debugging, you can log: Console.WriteLine($"Socket error: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Other unexpected errors (e.g., invalid host)
                    // For debugging: Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }



        private static async Task startPortChecker(string host, string ports, TextBox openPortTxtBox, TextBox closedTxtBox)
        {
            if (ports.Contains("-"))
            {
                string[] range = ports.Split('-');

                if (range.Length != 2)
                {
                    MessageBox.Show("Issue with port format did not detect excactly 2 numbers");
                    return;
                }
                else
                {
                    if (int.Parse(range[0]) < 1 || int.Parse(range[1]) > 65535)
                    {
                        MessageBox.Show("Issue with port, please select a port greater than 1 and less than 65535");
                        return;
                    }

                    else
                    {
                        for (int startPort = int.Parse(range[0]); startPort <= int.Parse(range[1]); startPort++)
                        {
                            bool isOpen = await checkPortAsync(host, startPort);

                            if (isOpen)
                            {
                                openPortTxtBox.AppendText (startPort.ToString() + Environment.NewLine);
                            }
                            else
                            {
                                closedTxtBox.AppendText(startPort.ToString() + Environment.NewLine);
                                
                            }
                        }

                    }


                }

            }
            else
            {
                bool isOpen = await checkPortAsync(host, int.Parse(ports));

                if (isOpen)
                {
                    openPortTxtBox.AppendText(ports + Environment.NewLine);
                }
                else { closedTxtBox.AppendText(ports + Environment.NewLine); }


            }

            MessageBox.Show("Complete!");


        }

        private async void startBtn_Click(object sender, EventArgs e)
        {

            string host = hostTxtBox.Text.Trim();
            string ports = portTxtBox.Text.Trim();
            // Validate host
            if (string.IsNullOrEmpty(host))
            {
                MessageBox.Show("Please enter a valid host, like 'localhost' or 'google.com'",
                    "Host Address Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate ports
            if (string.IsNullOrEmpty(ports))
            {
                MessageBox.Show("Please enter a valid port, like '8080' or '3333-9999'",
                    "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

             await startPortChecker(host, ports, openPortTxtBox, ClosedPorts);

        }

    }

}



