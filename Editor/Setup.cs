using System.IO;
using UnityEngine;
using UnityEditor;
using static UnityEditor.AssetDatabase;
using static System.IO.Path;

namespace RAStudio.SetupTools.Editor
{
    /// <summary>
    /// Provides utilities for setting up Unity projects with default settings and folders.
    /// </summary>
    public static class Setup
    {
        #region Constants
        private const string CompanyName = "RAStudio";
        private const string RootNamespace = "RAStudio";
        public static readonly string DefaultRootFolder = "_Project";
        public static readonly string[] DefaultFolders =
            { "Animation", "Art", "Prefabs", "ScriptableObjects", "Scripts", "Settings" };
        #endregion

        /// <summary>
        /// Updates the company name in Unity's player settings.
        /// </summary>
        /// <param name="companyName">The company name to set.</param>
        public static void UpdateCompanyName(string companyName)
        {
            PlayerSettings.companyName
                = companyName;
        }

        /// <summary>
        /// Updates the root namespace used for code generation in Unity.
        /// </summary>
        /// <param name="rootNamespace">The root namespace to set.</param>
        public static void UpdateRootNamespace(string rootNamespace)
        {
            EditorSettings.projectGenerationRootNamespace = rootNamespace;
        }

        /// <summary>
        /// Creates the default folders in the Unity project.
        /// </summary>

        public static void CreateDefaultFolders()
        {
            Folders.Create(DefaultRootFolder, DefaultFolders);
            Refresh();
            Folders.Move(DefaultRootFolder, "Scenes");
            Refresh();
        }

        /// <summary>
        /// Creates folders in the Unity project.
        /// </summary>

        public static void CreateFolders(string rootFolderName, string[] customFolders)
        {
            Folders.Create(rootFolderName, customFolders);
            Refresh();
        }

        /// <summary>
        /// Updates the default company name in Unity's player settings.
        /// </summary>

        public static void UpdateDefaultCompanyName()
        {
            UpdateCompanyName(CompanyName);
        }

        /// <summary>
        /// Updates the default root namespace used for code generation in Unity.
        /// </summary>
        public static void UpdateDefaultRootNamespace()
        {
            UpdateRootNamespace(RootNamespace);
        }
    }
}