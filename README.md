# RAStudio Setup Tools

**RAStudio Setup Tools** is a Unity package that provides utilities to simplify and streamline Unity project setup. This package includes tools for updating company names, root namespaces, and creating default folders within Unity projects.

## Features

- **Update Company Name:** Easily set the company name in Unity's player settings.
- **Update Root Namespace:** Change the root namespace used for code generation.
- **Create Default Folders:** Automatically create a set of predefined folders in your Unity project's `Assets` directory.

## Installation

1. **Download the Package:**

   - Clone or download this repository to your local machine.

2. **Add to Unity Project:**
   - Copy the contents of the `Packages` directory from this repository into the `Packages` folder of your Unity project.
     no

## Usage

1. **Update Company Name:**

   - In Unity, go to `Tools > RAStudio > Setup > Update Company Name` to set the company name to "RAStudio". You can modify the `Setup` script to use a different name if needed.

2. **Update Root Namespace:**

   - Navigate to `Tools > RAStudio > Setup > Update Root Namespace` to set the root namespace to "RAStudio". You can change the namespace in the `Setup` script as required.

3. **Create Default Folders:**
   - Use the menu option `Tools > RAStudio > Setup > Create Default Folders` to create the following default folders in your project's `Assets` directory:
     - `_Project`
     - `Animation`
     - `Art`
     - `Prefabs`
     - `ScriptableObjects`
     - `Scripts`
     - `Settings`

## Contributing

Contributions are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
