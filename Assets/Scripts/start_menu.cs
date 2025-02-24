using UnityEngine;
using UnityEngine.SceneManagement;
public class start_menu : MonoBehaviour
{

    public void new_game()
    {
        SceneManager.LoadScene("customer_view");
    }

}