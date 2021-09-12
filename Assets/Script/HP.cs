using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Sprite hp0, hp1, hp2, hp3;
    private Image imgcomponent;
    public static int point;
    public GameObject gameovercanvas;

    // Start is called before the first frame update
    void Start()
    {
        point = 3;
        imgcomponent = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (point == 3)
        {
            imgcomponent.sprite = hp3;
        }
        else if(point == 2)
        {
            imgcomponent.sprite = hp2;
        }
        else if (point == 1)
        {
            imgcomponent.sprite = hp1;
        }
        else
        {
            imgcomponent.sprite = hp0;
            StartCoroutine(Cooldown());
        }
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.5f);
        gameovercanvas.SetActive(true);
    }

}
