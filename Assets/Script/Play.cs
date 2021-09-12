using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public GameObject player;
    public Button PlayButton;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(play);
    }

    void play()
    {
        player.SetActive(true);
        this.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
