using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firebar : MonoBehaviour
{
    public Sprite fb0, fb1, fb2, fb3, fb4, fb5;
    private Image imgcomponent;
    public static int bullet;

    // Start is called before the first frame update
    void Start()
    {
        bullet = 0;
        imgcomponent = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bullet == 0)
        {
            imgcomponent.sprite = fb0;
        }else if (bullet == 1)
        {
            imgcomponent.sprite = fb1;
        }else if (bullet == 2)
        {
            imgcomponent.sprite = fb2;
        }else if (bullet == 3)
        {
            imgcomponent.sprite = fb3;
        }else if (bullet == 4)
        {
            imgcomponent.sprite = fb4;
        }else if (bullet == 5)
        {
            imgcomponent.sprite = fb5;
        }
    }


}
