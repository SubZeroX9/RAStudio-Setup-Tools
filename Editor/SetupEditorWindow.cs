using RAStudio.SetupTools.Editor;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SetupEditorWindow : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    private Toggle m_DefaultNameToggle;
    private VisualElement m_FoldersContainer;

    private TextField m_RootFolderNameField;
    private List<TextField> m_CustomFoldersList;
    private int customFolderCount = 0;

    private Toggle m_DefaultCompanyName;
    private TextField m_CompanyNameField;

    private Toggle m_DefaultRootNamespace;
    private TextField m_RootNamespaceField;

    [MenuItem("Tools/RAStudio/Setup/SetupEditorWindow")]
    public static void ShowExample()
    {
        SetupEditorWindow wnd = GetWindow<SetupEditorWindow>();
        wnd.titleContent = new GUIContent("Setup Window");
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        m_VisualTreeAsset.CloneTree(root);

        InitFolderTab(root);
        InitSettingsTab(root);
    }

    private void InitSettingsTab(VisualElement root)
    {
        m_DefaultCompanyName = root.Q<Toggle>("default-company-name-toggle");
        m_CompanyNameField = root.Q<TextField>("company-name-field");

        m_DefaultRootNamespace = root.Q<Toggle>("default-root-namespace-toggle");
        m_RootNamespaceField = root.Q<TextField>("root-namespace-field");

        m_DefaultCompanyName.RegisterValueChangedCallback(evt =>
        {
            m_CompanyNameField.style.display = evt.newValue ? DisplayStyle.None : DisplayStyle.Flex;
        });

        m_DefaultRootNamespace.RegisterValueChangedCallback(evt =>
        {
            m_RootNamespaceField.style.display = evt.newValue ? DisplayStyle.None : DisplayStyle.Flex;
        });

        m_CompanyNameField.style.display = m_DefaultCompanyName.value ? DisplayStyle.None : DisplayStyle.Flex;
        m_RootNamespaceField.style.display = m_DefaultRootNamespace.value ? DisplayStyle.None : DisplayStyle.Flex;

        var updateCompanyNameButton = root.Q<Button>("update-company-name-btn");
        updateCompanyNameButton.clicked += OnUpdateCompanyNameClicked;

        var updateRootNamespaceButton = root.Q<Button>("update-root-namespace-btn");
        updateRootNamespaceButton.clicked += OnUpdateRootNamespaceClicked;
    }

    private void InitFolderTab(VisualElement root)
    {
        m_CustomFoldersList = new List<TextField>();
        customFolderCount = 0;


        m_DefaultNameToggle = root.Q<Toggle>("default-names-toggle");
        m_FoldersContainer = root.Q<VisualElement>("folders-container");

        m_DefaultNameToggle.RegisterValueChangedCallback(evt =>
        {
            m_FoldersContainer.style.display = evt.newValue ? DisplayStyle.None : DisplayStyle.Flex;
        });

        m_FoldersContainer.style.display = m_DefaultNameToggle.value ? DisplayStyle.None : DisplayStyle.Flex;

        m_RootFolderNameField = root.Q<TextField>("root-folder-name");

        var addFolderButton = rootVisualElement.Q<Button>("add-folder-btn");
        addFolderButton.clicked += AddCustomFolderField;

        var createButton = root.Q<Button>("create-btn");
        createButton.clicked += OnCreateClicked;
    }

    private void OnCreateClicked()
    {
        if (m_DefaultNameToggle.value)
        {
            Debug.Log("Create folders with default names");
            Setup.CreateDefaultFolders();
            return;
        }

        var subFolders = GetFolderNames();
        Setup.CreateFolders(m_RootFolderNameField.value, subFolders.ToArray());
        Debug.Log("Create folders with custom names");
    }


    private List<string> GetFolderNames()
    {
        List<string> folderNames = new List<string>();
        foreach (var textField in m_CustomFoldersList)
        {
            folderNames.Add(textField.value);
        }
        return folderNames;
    }

    private void AddCustomFolderField()
    {
        customFolderCount++;
        var textField = new TextField($"Folder {customFolderCount}:")
        {
            name = $"custom-folder-{customFolderCount}",
            value = $"CustomFolder{customFolderCount}"
        };
        m_CustomFoldersList.Add(textField);
        m_FoldersContainer.Add(textField);
    }

    private void OnUpdateCompanyNameClicked()
    {
        if(m_DefaultCompanyName.value)
        {
            Debug.Log("Update company name with default name");
            Setup.UpdateDefaultCompanyName();
            return;
        }

        Debug.Log("Update company name with custom name");
        Setup.UpdateCompanyName(m_CompanyNameField.value);
    }

    private void OnUpdateRootNamespaceClicked()
    {
        if(m_DefaultRootNamespace.value)
        {
            Debug.Log("Update root namespace with default name");
            Setup.UpdateDefaultRootNamespace();
            return;
        }

        Debug.Log("Update root namespace with custom name");
        Setup.UpdateRootNamespace(m_RootNamespaceField.value);
    }
}
