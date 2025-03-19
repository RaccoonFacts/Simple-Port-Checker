# Simple-Port-Checker

![image](https://github.com/user-attachments/assets/61df61ff-93d0-46d2-b158-fafa9ac347cf)

A simple Windows Forms application written in C# to check whether specified TCP ports are open or closed on a given host. The tool supports checking a single port or a range of ports and displays the results in separate textboxes for open and closed ports.

## Features
- Check a single port (e.g., "8080") or a range of ports (e.g., "3333-9999").
- Displays open ports and closed ports in separate multi-line textboxes.
- Validates user input for host and port values.
- Asynchronous port checking with a configurable 5-second timeout per port.
- User-friendly error messages via message boxes.

## Prerequisites
- **Operating System**: Windows (due to Windows Forms dependency).
- **.NET Framework**: .NET Framework 4.x or later (or compatible .NET version).
- **IDE**: Visual Studio (recommended for building and running the project).

## Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/raccoonfacts/simple-Port-Checker.git
   
## Usage
### Launch the Application:
- Run the compiled executable or start it from Visual Studio.
- Enter Host and Ports:
- Host: Input a valid hostname (e.g., localhost, google.com) in the "Host" textbox.
- Ports: Input a single port (e.g., 8080) or a range (e.g., 3333-9999) in the "Ports" textbox.
### Start the Scan:
- Click the "Start" button to begin checking the specified ports.
### The application will:
- Append open ports to the "Open Ports" textbox, one per line.
-Append closed ports to the "Closed Ports" textbox, one per line.
-A "Complete!" message box will appear when the scan finishes.
## Example Inputs:
- Host: google.com, Ports: 80 → Checks if port 80 is open.
- Host: localhost, Ports: 1024-1026 → Checks ports 1024 to 1026.
