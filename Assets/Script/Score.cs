using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int nilai;
    public GameObject fire;
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        nilai = 0;
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nilai >= HighScore.Highscore)
        {
           PlayerPrefs.SetInt("HighScore", nilai);
        }

        ScoreText.text = nilai.ToString();
    }
}
