using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Animator Animation;
    public float Jump;
    public GameObject bullet1, bullet2, point1, point2, Fire, Scorepoint;
    public Button Jumpbutton, FireButton;
    bool Canshoot;
    Renderer m; 
    public AudioClip spawn, hit, fire, coin, fireball;
    AudioSource audioSource;

    public GameObject destroyEffect;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Canshoot = true;
        Animation = GetComponent<Animator>();
        Jumpbutton.onClick.AddListener(lompat);
        FireButton.onClick.AddListener(shoot);

        m = GetComponent<Renderer>();
    }

    public void lompat()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, Jump);
        Animation.SetBool("Jump", true);
    }

    void shoot()
    {
        if (Canshoot && Firebar.bullet == 5)
        {
            Camera.shake = true;
            Firebar.bullet -= 5;
            Instantiate(bullet2, point2.transform.position, Quaternion.identity);
            audioSource.PlayOneShot(fireball, 1f);
            Animation.SetBool("Shoot", true);
            StartCoroutine(Cooldown());
        }
        else if (Canshoot)
        {
            Camera.shake = true;
            Instantiate(bullet1, point1.transform.position, Quaternion.identity);
            audioSource.PlayOneShot(fire, 0.3f);
            Animation.SetBool("Shoot", true);
            Canshoot = false;
            StartCoroutine(Cooldown());
        }
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.3f);
        Animation.SetBool("Shoot", false);
        Canshoot = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Grounds"))
        {
            Animation.SetBool("Jump", false);
            audioSource.PlayOneShot(spawn, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Fire") || collision.gameObject.tag.Equals("Enemy"))
        {
            //Destroy(gameObject);
            HP.point-= 1;
            Handheld.Vibrate();
            if (HP.point <= 0)
            {
                m.material.color = new Color(1, 1, 1, 0);
                audioSource.PlayOneShot(hit, 1f);
                Instantiate(destroyEffect, transform.position, Quaternion.identity);
                StartCoroutine(delay());
            }else if(HP.point >= 1)
            {
                m.material.color = new Color(1, 1, 1, 0);
                audioSource.PlayOneShot(hit, 1f);
                StartCoroutine(Flash());
            }
        }

        if (collision.gameObject.tag.Equals("Firepoint"))
        {
            Fire.SetActive(true);
            Scorepoint.SetActive(true);
        }


        if (collision.gameObject.tag.Equals("Score"))
        {

            audioSource.PlayOneShot(coin, 1f);
            Score.nilai += 10;
            EnemySpawn.Score = Score.nilai;

            if(Firebar.bullet < 5)
            {
                Firebar.bullet += 1;
            }
        }
    }

    IEnumerator Flash()
    {
        yield return new WaitForSeconds(0.1f);
        m.material.color = new Color(1, 1, 1, 1);
        yield return new WaitForSeconds(0.1f);
        m.material.color = new Color(1, 1, 1, 0);
        yield return new WaitForSeconds(0.1f);
        m.material.color = new Color(1, 1, 1, 1);
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
