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
