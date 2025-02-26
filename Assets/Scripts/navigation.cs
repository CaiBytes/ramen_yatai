using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    
    private string currentSeason = "";
    //Checks currentSeason string and loads correct customer view when customer_button is clicked
    public void customer_view()
    {
        currentSeason = StartMenu.selectedSeason;
        if (currentSeason == "winter")
        {
            SceneManager.LoadScene("winter_view");
        } else 
        {
            SceneManager.LoadScene("customer_view");
        }
    }

    //When kitchen_button is clicked, loads kitchen view
    public void kitchen_view()
    {
        SceneManager.LoadScene("kitchen_view");
    }

    //Closes current game session, returns to start menu
    public void quit_game()
    {
        SceneManager.LoadScene("start_menu");
    }

}