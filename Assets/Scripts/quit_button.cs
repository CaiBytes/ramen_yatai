using UnityEngine;
using UnityEngine.SceneManagement;

public class quit_button : MonoBehaviour
{
 
 public void quit_game()
    {
        SceneManager.LoadScene("start_menu");
    }
    
}
