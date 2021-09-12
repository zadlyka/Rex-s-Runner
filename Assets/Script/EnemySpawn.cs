using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public static int Score;
    public static bool Spawn;
    public GameObject Enemies, point1, point2;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Enemies, point2.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Score % 3 == 0 && Spawn)
        {
            Instantiate(Enemies, point1.transform.position, Quaternion.identity);
            Spawn = false;
        }
        else if (Score % 5 == 0 && Spawn)
        {
            Instantiate(Enemies, point2.transform.position, Quaternion.identity);
            Spawn = false;
        }
    }
}
