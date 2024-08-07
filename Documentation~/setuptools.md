# RAStudio Setup Tools

## Overview

**RAStudio Setup Tools** is a Unity package designed to simplify and streamline the setup of Unity projects. This package provides tools to update the company name and root namespace, and create default folders in your project.

## Features

- **Dynamic Folder Creation:** Add custom folders dynamically via the UI.
- **Update Company Name:** Set the company name used in Unity's player settings.
- **Update Root Namespace:** Change the root namespace used for code generation in Unity.
- **Create Default Folders:** Automatically create a set of predefined folders in the `Assets` directory of your project.

## Installation

### Option 1: Using Unity Package Manager

1. Open your Unity project.
2. In the Unity Editor, go to `Window > Package Manager`.
3. Click the `+` button in the top-left corner of the Package Manager window.
4. Select `Add package from git URL...`.
5. Enter the following URL: `https://github.com/SubZeroX9/RAStudio-Setup-Tools.git`
6. Click `Add` to install the package.

### Option 2: Manual Installation

1. **Download the Package:**

   - Clone or download this repository to your local machine.

2. **Add to Unity Project:**

   - Copy the contents of the `Packages` directory from this repository into the `Packages` folder of your Unity project.

## Usage

### Open Setup Window

1. In Unity, go to `Tools > RAStudio > Setup Window` to open the RAStudio Setup Tools window.

### Folders Tab

- **Use Default Folder Names:** Toggle to use default folder names.
- **Add Custom Folders:** Click "Add Folder" to add fields for custom folder names.
- **Create Folders:** Click "Create" to create folders in your project's `Assets` directory based on the specified names.

### Settings Tab

- **Update Company Name:** Toggle to use the default company name or enter a custom name. Click "Update" to apply the changes.
- **Update Root Namespace:** Toggle to use the default root namespace or enter a custom namespace. Click "Update" to apply the changes.

## Troubleshooting

- **Folders Not Created:** Ensure you have the necessary permissions to create folders in the `Assets` directory. Check Unity console for any errors and ensure that the `Setup` script is correctly placed in the `Editor` folder.
- **Company Name or Namespace Not Updated:** Verify that you have the correct permissions to change player settings and project settings. Make sure you are using the latest version of the package.

## Contributing

Contributions are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](../LICENSE.md) file for details.
