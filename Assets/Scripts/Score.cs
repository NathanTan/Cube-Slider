using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshPro  scoreTextPro;

    void Start() {
        // scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextPro = GetComponent<TextMeshPro> ();
        scoreTextPro.text = "Score: " + player.position.z.ToString("0");
        
    }
}
