# SWE40006 Deployment Portfolio - Task 1

This project contains a C# Windows Forms application and a WiX v3 MSI installer.

## Contents

- `src/DeploymentPortfolioDemo` - the main Windows Forms application.
- `src/DeploymentPortfolio.Core` - DLL used to create the greeting message.
- `src/DeploymentPortfolio.Diagnostics` - DLL used to display the dependency status.
- `installer` - WiX v3 installer project and `Product.wxs` file.
- `docs` - report draft, screenshot checklist, and error notes.

## Requirements

- Visual Studio 2022 with .NET desktop development and the .NET Framework 4.8 targeting pack.
- WiX Toolset v3.11.x and the WiX Visual Studio extension.

## Build

1. Open `DeploymentPortfolioDemo.sln` in Visual Studio.
2. Select the **Release** configuration.
3. Select **Build Solution**.

The MSI installer is created at:

`installer\bin\Release\DeploymentPortfolioInstaller.msi`

The installer deploys the main executable and these dependencies:

- `DeploymentPortfolio.Core.dll`
- `DeploymentPortfolio.Diagnostics.dll`

## Testing

Install the MSI, then run `DeploymentPortfolioDemo.exe` from:

`C:\Program Files\Deployment Portfolio Demo`

Enter a name and select **Run dependency check**. The greeting and status message confirm that both DLLs have loaded successfully.

The public source-code URL for this task should point to this folder in the GitHub repository. Build output, binaries, and signing certificates are excluded by `.gitignore`.
