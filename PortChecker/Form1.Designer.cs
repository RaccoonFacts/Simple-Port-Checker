namespace PortChecker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portTxtBox = new System.Windows.Forms.TextBox();
            this.prtLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.hostTxtBox = new System.Windows.Forms.TextBox();
            this.HostLbl = new System.Windows.Forms.Label();
            this.openPortTxtBox = new System.Windows.Forms.TextBox();
            this.OpenPortLbl = new System.Windows.Forms.Label();
            this.ClosedPorts = new System.Windows.Forms.TextBox();
            this.closedPortLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portTxtBox
            // 
            this.portTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTxtBox.Location = new System.Drawing.Point(17, 131);
            this.portTxtBox.Name = "portTxtBox";
            this.portTxtBox.Size = new System.Drawing.Size(303, 31);
            this.portTxtBox.TabIndex = 0;
            // 
            // prtLbl
            // 
            this.prtLbl.AutoSize = true;
            this.prtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtLbl.Location = new System.Drawing.Point(12, 103);
            this.prtLbl.Name = "prtLbl";
            this.prtLbl.Size = new System.Drawing.Size(132, 25);
            this.prtLbl.TabIndex = 1;
            this.prtLbl.Text = "Enter Port: ";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(17, 182);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 55);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // hostTxtBox
            // 
            this.hostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTxtBox.Location = new System.Drawing.Point(17, 37);
            this.hostTxtBox.Name = "hostTxtBox";
            this.hostTxtBox.Size = new System.Drawing.Size(303, 31);
            this.hostTxtBox.TabIndex = 3;
            this.hostTxtBox.Text = "localhost";
            // 
            // HostLbl
            // 
            this.HostLbl.AutoSize = true;
            this.HostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostLbl.Location = new System.Drawing.Point(12, 9);
            this.HostLbl.Name = "HostLbl";
            this.HostLbl.Size = new System.Drawing.Size(227, 25);
            this.HostLbl.TabIndex = 4;
            this.HostLbl.Text = "Enter Host Location:";
            // 
            // openPortTxtBox
            // 
            this.openPortTxtBox.Location = new System.Drawing.Point(348, 37);
            this.openPortTxtBox.Multiline = true;
            this.openPortTxtBox.Name = "openPortTxtBox";
            this.openPortTxtBox.Size = new System.Drawing.Size(203, 365);
            this.openPortTxtBox.TabIndex = 5;
            // 
            // OpenPortLbl
            // 
            this.OpenPortLbl.AutoSize = true;
            this.OpenPortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPortLbl.Location = new System.Drawing.Point(343, 9);
            this.OpenPortLbl.Name = "OpenPortLbl";
            this.OpenPortLbl.Size = new System.Drawing.Size(137, 25);
            this.OpenPortLbl.TabIndex = 6;
            this.OpenPortLbl.Text = "Open Ports:";
            // 
            // ClosedPorts
            // 
            this.ClosedPorts.Location = new System.Drawing.Point(585, 37);
            this.ClosedPorts.Multiline = true;
            this.ClosedPorts.Name = "ClosedPorts";
            this.ClosedPorts.Size = new System.Drawing.Size(203, 365);
            this.ClosedPorts.TabIndex = 7;
            // 
            // closedPortLbl
            // 
            this.closedPortLbl.AutoSize = true;
            this.closedPortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedPortLbl.Location = new System.Drawing.Point(580, 9);
            this.closedPortLbl.Name = "closedPortLbl";
            this.closedPortLbl.Size = new System.Drawing.Size(154, 25);
            this.closedPortLbl.TabIndex = 8;
            this.closedPortLbl.Text = "Closed Ports:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closedPortLbl);
            this.Controls.Add(this.ClosedPorts);
            this.Controls.Add(this.OpenPortLbl);
            this.Controls.Add(this.openPortTxtBox);
            this.Controls.Add(this.HostLbl);
            this.Controls.Add(this.hostTxtBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.prtLbl);
            this.Controls.Add(this.portTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Port Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label prtLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label HostLbl;
        private System.Windows.Forms.Label OpenPortLbl;
        private System.Windows.Forms.Label closedPortLbl;
        public System.Windows.Forms.TextBox portTxtBox;
        public System.Windows.Forms.TextBox hostTxtBox;
        public System.Windows.Forms.TextBox openPortTxtBox;
        public System.Windows.Forms.TextBox ClosedPorts;
    }
}

