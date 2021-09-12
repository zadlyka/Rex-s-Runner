using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int Highscore;
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Highscore = PlayerPrefs.GetInt("HighScore", 0);
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Highscore.ToString();
    }
}
