using System.IO;
using UnityEngine;
using UnityEditor;
using static UnityEditor.AssetDatabase;

namespace RAStudio.SetupTools.Editor
{
    /// <summary>
    /// Provides utilities for setting up Unity projects with default settings and folders.
    /// </summary>
    public static class Setup
    {
        #region Company Name
        /// <summary>
        /// Menu item to update the company name to the default value "RAStudio".
        /// </summary>
        [MenuItem("Tools/RAStudio/Setup/Update Company Name")]
        public static void UpdateCompanyNameDefault()
        {
            string companyName = "RAStudio";
            UpdateCompanyName(companyName);
        }

        /// <summary>
        /// Updates the company name in Unity's player settings.
        /// </summary>
        /// <param name="companyName">The company name to set.</param>
        public static void UpdateCompanyName(string companyName)
        {
            PlayerSettings.companyName
                = companyName;
        }
        #endregion

        #region Namespace
        /// <summary>
        /// Menu item to update the root namespace to the default value "RAStudio".
        /// </summary>
        [MenuItem("Tools/RAStudio/Setup/Update Root Namespace")]
        public static void UpdateRootNamespaceDefault()
        {
            string rootNamespace = "RAStudio";
            UpdateRootNamespace(rootNamespace);
        }

        /// <summary>
        /// Updates the root namespace used for code generation in Unity.
        /// </summary>
        /// <param name="rootNamespace">The root namespace to set.</param>
        public static void UpdateRootNamespace(string rootNamespace)
        {
            EditorSettings.projectGenerationRootNamespace = rootNamespace;
        }
        #endregion

        #region Default Folders
        /// <summary>
        /// Menu item to create default folders in the project's Assets directory.
        /// </summary>
        [MenuItem("Tools/RAStudio/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Folders.CreateDefault("_Project","Animation","Art","Prefabs","ScriptableObjects","Scripts","Settings");
            Refresh();
        }

        /// <summary>
        /// Provides methods for creating folders in the Unity project.
        /// </summary>
        public static class Folders
        {
            /// <summary>
            /// Creates a set of folders in the specified root directory within the project's Assets folder.
            /// </summary>
            /// <param name="root">The root folder where the new folders will be created.</param>
            /// <param name="folders">An array of folder names to create.</param>
            public static void CreateDefault(string root, params string[] folders)
            {
                string fullPath = Path.Combine(Application.dataPath, root);
                foreach (var folder in folders)
                {
                    string path = Path.Combine(fullPath, folder);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
            }
        }
        #endregion
    }
}