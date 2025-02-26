using UnityEngine;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public GameObject selectionMenu;
    public TMP_InputField userInputStoreName;
    public string storeName;

    private void Start()
    {
        if (selectionMenu != null)
        {
            selectionMenu.SetActive(false); // Ensures the selection menu is hidden at the start
        }
        else
        {
            Debug.LogWarning("Selection menu GameObject is not assigned in the Inspector.");
        }
    }

    public void LaunchSelection()
    {
        if (selectionMenu != null)
        {
            selectionMenu.SetActive(!selectionMenu.activeSelf); // Toggle visibility
        }
    }

    public void CloseSelection()
    {
        if (selectionMenu != null)
        {
            selectionMenu.SetActive(!selectionMenu.activeSelf);
        }
    }

    public void StartGame()
    {
        storeName = userInputStoreName.text;
        Debug.LogWarning(storeName);
    }
}






































