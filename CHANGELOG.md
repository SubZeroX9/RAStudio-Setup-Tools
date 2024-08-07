# Changelog

All notable changes to this project will be documented in this file.

## [1.1.0] - 2024-08-06

### Added

- **Dynamic Folder Creation**: Added the ability to create custom folders dynamically.
- **Tab View**: Integrated tab view for better organization of settings.
  - **Folders Tab**: Allows users to create folders with either default or custom names.
  - **Settings Tab**: Allows users to update the company name and root namespace.

### Changed

- **Transition to UI Toolkit**: Replaced menu items with a new UI Editor window using the Unity UI Toolkit for better user experience and organization.

## [1.0.0] - 2024-07-20

### Added

- Initial release of RAStudio Setup Tools.
  - **Update Company Name** tool to set the company name in Unity's player settings.
  - **Update Root Namespace** tool to change the root namespace used for code generation.
  - **Create Default Folders** tool to automatically create the following default folders in your project's `Assets` directory:
    - `_Project`
    - `Animation`
    - `Art`
    - `Prefabs`
    - `ScriptableObjects`
    - `Scripts`
    - `Settings`

---

For more detailed information about each release, refer to the specific version entries above.
