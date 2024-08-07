# RAStudio Setup Tools

**RAStudio Setup Tools** is a Unity package that provides utilities to simplify and streamline Unity project setup. This package includes tools for updating company names, root namespaces, and creating default folders within Unity projects.

## Features

- **Dynamic Folder Creation:** Add custom folders dynamically via the UI.
- **Update Company Name:** Easily set the company name in Unity's player settings.
- **Update Root Namespace:** Change the root namespace used for code generation.
- **Create Default Folders:** Automatically create a set of predefined folders in your Unity project's `Assets` directory.

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

1. **Open Setup Window:**

   - In Unity, go to `Tools > RAStudio > Setup Window` to open the RAStudio Setup Tools window.

2. **Folders Tab:**

   - **Use Default Folder Names:** Toggle to use default folder names.
   - **Add Custom Folders:** Click "Add Folder" to add fields for custom folder names.
   - **Create Folders:** Click "Create" to create folders in your project's `Assets` directory based on the specified names.

3. **Settings Tab:**
   - **Update Company Name:** Toggle to use the default company name or enter a custom name. Click "Update" to apply the changes.
   - **Update Root Namespace:** Toggle to use the default root namespace or enter a custom namespace. Click "Update" to apply the changes.

## Contributing

Contributions are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
