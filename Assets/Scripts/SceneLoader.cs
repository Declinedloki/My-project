using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyGame
{
    public class SceneLoader : MonoBehaviour
    {
        // Method to load the Game Screen scene
        public void LoadGameScreen()
        {
            SceneManager.LoadScene("Scenes/Game Screen");
        }

        // Method to load the Main Screen scene
        public void LoadMainScreen()
        {
            SceneManager.LoadScene("Scenes/Main Screen");
        }
    }
}
