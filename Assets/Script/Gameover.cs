using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    Text ScoreText;
    int temp;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = Score.nilai;
        ScoreText.text = temp.ToString();
    }
}
