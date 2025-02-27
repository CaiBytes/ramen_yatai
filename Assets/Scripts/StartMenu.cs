using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class StartMenu : MonoBehaviour
{
    public GameObject selectionMenu;
    public TMP_InputField userInputStoreName;
    public string storeName;
    public static string selectedSeason = "";


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

    public void SelectSpring()
    {
        selectedSeason = "spring";
        Debug.Log("Spring selected");
    }
    public void SelectWinter()
    {
        selectedSeason = "winter";
        Debug.Log("Winter selected");
    }


    public void StartGame()
    {
        storeName = userInputStoreName.text;
        Debug.LogWarning(storeName);

        if(selectedSeason == "spring")
        {
            SceneManager.LoadScene("customer_view");
        }
        else if (selectedSeason == "winter")
        {
            SceneManager.LoadScene("winter_view");
        }
    }
}






































