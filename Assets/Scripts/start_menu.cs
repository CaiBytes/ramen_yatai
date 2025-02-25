using UnityEngine;
using UnityEngine.SceneManagement;

//this code is not functioning presently
using System.Collections;
public class start_menu : MonoBehaviour {
    public GameObject popupContainer;  // The container for the popup
    public SceneReference selection_menu;  // The scene containing the popup UI

    public void new_game() {
        SceneManager sceneManager = SceneManager.instance;
        sceneManager.AdditiveScene(popupScene, "Popup");
    }
}