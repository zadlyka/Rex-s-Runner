using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOButton : MonoBehaviour
{
    public Button TryagainButton, ExitButton;
    // Start is called before the first frame update
    void Start()
    {
        TryagainButton.onClick.AddListener(tryagain);
        ExitButton.onClick.AddListener(exit);
    }

    void tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void exit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
