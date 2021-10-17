using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globo1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float xSpeed, ySpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed * 2, ySpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Bullet"))
        {
            Die();


        } else if ((col.gameObject.tag == "Limit")) {

            Die();

        }


    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
