# Syncfusion WinForms Data Grid in .NET Core 3.0

This repository contains a sample Windows Forms application that demonstrates how to use the [Syncfusion WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) control in a .NET Core 3.0 application.

The sample creates an `Data Grid`, binds it to a `DataTable`, and displays employee information in a simple data-bound form.

## Features

- .NET Core 3.0 WinForms application
- Syncfusion WinForms Data Grid integration
- Data binding using `DataTable`
- Sample employee records displayed in the grid
- Ready-to-run Visual Studio solution

## Project structure

- `NETCoreWFDemo.sln` - Visual Studio solution file
- `NETCoreWFDemo/` - WinForms project folder
  - `NETCoreWFDemo.csproj` - .NET Core 3.0 project configuration
  - `Form1.cs` - Main form logic and sample data setup
  - `Form1.Designer.cs` - Designer-generated form code
  - `Program.cs` - Application startup

## Prerequisites

Before running this project, ensure you have:

- Visual Studio 2019
- .NET Core 3.0 SDK
- Windows operating system (WinForms requires Windows)

## Getting started

1. Clone this repository to your local machine.
2. Open `NETCoreWFDemo.sln` in Visual Studio 2019.
3. Restore the NuGet packages when prompted.
4. Build the solution.
5. Press `F5` to run the application.

## NuGet package used

This sample references the following Syncfusion NuGet package:

- `Syncfusion.SfDataGrid.WinForms` version `17.1.0.42`

## Output

When the application runs, it displays a `Data Grid` populated with employee details such as:

- Employee ID
- Employee Name
- Customer ID
- Country
- Date

## Related links

- [Syncfusion WinForms DataGrid product page](https://www.syncfusion.com/winforms-ui-controls/datagrid)
- [Syncfusion WinForms documentation](https://help.syncfusion.com/windowsforms)
