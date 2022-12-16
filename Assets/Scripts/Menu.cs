using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameManager gameManager;

    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void HandleInputData(int val) {
        
        if (val == 0) {
            // set to Easy here
            Debug.Log("easy mode");
        } else if (val == 1) {
            // set to normal here
            Debug.Log("Normal mode");
        }
        gameManager.SetDifficulty(val);
        
    }
}
