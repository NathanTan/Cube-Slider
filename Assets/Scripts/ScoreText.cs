using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Start() {
        // scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        var scoreValue = player.position.z;
        if (scoreValue < 0) {
            scoreValue = 0;
        }
        scoreValue = scoreValue / 4;
        scoreText.text = "Score: " + scoreValue.ToString("0");
        
    }
}
