using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    Button PauseButton;
    private Image imgcomponent;
    public Sprite resumeimg, pauseimg;
    bool pausecondition;
    public AudioClip clicksounds;
    AudioSource audioSource, temp;
    public GameObject maincamera;


    // Start is called before the first frame update
    void Start()
    {
        temp = maincamera.GetComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();
        pausecondition = false;
        PauseButton = this.GetComponent<Button>();
        imgcomponent = this.GetComponent<Image>();
    }

    void pause()
    {
        temp.mute = true;
        pausecondition = true;
        audioSource.PlayOneShot(clicksounds, 0.1f);
        Time.timeScale = 0;
        imgcomponent.sprite = resumeimg;
    }

    void resume()
    {
        temp.mute = false;
        pausecondition = false;
        audioSource.PlayOneShot(clicksounds, 0.1f);
        Time.timeScale = 1;
        imgcomponent.sprite = pauseimg;
    }

    // Update is called once per frame
    void Update()
    {
        if (pausecondition)
        {
            PauseButton.onClick.AddListener(resume);
        }
        else if (!pausecondition)
        {
            PauseButton.onClick.AddListener(pause);
        }
    }
}
