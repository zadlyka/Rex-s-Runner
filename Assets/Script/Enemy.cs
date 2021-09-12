using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            EnemySpawn.Spawn = true;
        }
        if (collision.gameObject.tag.Equals("Destroy"))
        {
            Destroy(gameObject);
            EnemySpawn.Spawn = true;
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            EnemySpawn.Spawn = true;
        }
    }



}


