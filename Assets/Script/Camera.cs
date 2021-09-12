using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Animator Animation;
    public static bool shake;
    // Start is called before the first frame update
    void Start()
    {
        Animation = GetComponent<Animator>();
        shake = false;
    }

    void Update()
    {
        if (shake)
        {
            Animation.SetTrigger("Shake");
            shake = false;
        }
    }
}
