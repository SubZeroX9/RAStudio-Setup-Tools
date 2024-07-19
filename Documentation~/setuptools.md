# RAStudio Setup Tools

## Overview

**RAStudio Setup Tools** is a Unity package designed to simplify and streamline the setup of Unity projects. This package provides tools to update the company name and root namespace, and create default folders in your project.

## Features

- **Update Company Name:** Set the company name used in Unity's player settings.
- **Update Root Namespace:** Change the root namespace used for code generation in Unity.
- **Create Default Folders:** Automatically create a set of predefined folders in the `Assets` directory of your project.

## Installation

1. **Download the Package:**

   - Clone or download this repository to your local machine.

2. **Add to Unity Project:**

   - Copy the contents of the `Packages` directory from this repository into the `Packages` folder of your Unity project.

   Alternatively, you can add the package via the Unity Package Manager by referencing the Git URL directly.

## Usage

### Update Company Name

To update the company name:

1. Open Unity and navigate to `Tools > RAStudio > Setup > Update Company Name`.
2. The company name will be set to "RAStudio" by default. You can modify the `Setup` script to use a different name if needed.

### Update Root Namespace

To update the root namespace:

1. Open Unity and navigate to `Tools > RAStudio > Setup > Update Root Namespace`.
2. The root namespace will be set to "RAStudio" by default. You can change the namespace in the `Setup` script as required.

### Create Default Folders

To create default folders:

1. Open Unity and navigate to `Tools > RAStudio > Setup > Create Default Folders`.
2. The following folders will be created in the `Assets` directory:
   - `_Project`
   - `Animation`
   - `Art`
   - `Prefabs`
   - `ScriptableObjects`
   - `Scripts`
   - `Settings`

## Troubleshooting

- **Folders Not Created:** Ensure you have the necessary permissions to create folders in the `Assets` directory. Check Unity console for any errors and ensure that the `Setup` script is correctly placed in the `Editor` folder.

- **Company Name or Namespace Not Updated:** Verify that you have the correct permissions to change player settings and project settings. Make sure you are using the latest version of the package.

## Contributing

Contributions are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](../LICENSE.md) file for details.
