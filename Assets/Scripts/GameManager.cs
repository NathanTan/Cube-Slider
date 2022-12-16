using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    bool levelComplete = false;
    int difficulty = 1;
    // bool inMenu = true;

    public GameObject completeLevelUI;

    public void Start() {
        // this.inMenu = false;
        Debug.Log("Difficulty: " + this.difficulty);
        this.difficulty = GlobalControl.Instance.difficulty;
    }

    public void SetDifficulty(int index) {
        this.difficulty = index;
        if (index == 0) {
            Debug.Log("Easy Mode");
        } else if (index == 1) {
            Debug.Log("Normal Mode");
        } else if (index == 2) {
            Debug.Log("Hard Mode");
        }
    }

    public int getDifficulty()
    {
        return this.difficulty;
    }

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        levelComplete = true;

        // Update global instance before transitioning
        //GlobalControl.Instance.difficulty = difficulty;
    }

    public float RESTART_DELAY = 1.5f;
    // Start is called before the first frame update

    public void EndGame() {
        if (gameOver == false && !levelComplete) {
            gameOver = true;

            Invoke("Restart", RESTART_DELAY);
        }
       
    }


    void Restart() {
        // Update global instance before transitioning
        GlobalControl.Instance.difficulty = difficulty;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
