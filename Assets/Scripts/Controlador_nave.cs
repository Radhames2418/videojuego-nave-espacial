using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_nave : MonoBehaviour
{
    public float velocidad = 3f;
    public GameManager gameManager;


    int delay;
    GameObject a;
    public GameObject bullet;
    public float speed;
    public int helio = 100;

    void Awake()
    {
        a = transform.Find("Bullet").gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.Space) && delay > 150)
        {
            Shoot();
        }
        delay++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Limit")
        {
            velocidad = 0f;
            gameManager.gameOver = true;
            Destroy(gameObject);
        }

        if ((collision.gameObject.tag == "Lateral"))
        {
            Die();
        }
    }


    public void statusHelio(int He)
    {
        helio += He;
    }

    void Shoot()
    {
        delay = 0;
        Instantiate(bullet, a.transform.position, Quaternion.identity);
    }

    public void Die()
    {
        Destroy(gameObject);
    }


}
