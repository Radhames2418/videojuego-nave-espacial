using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public int xSpeed, ySpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ChageDirection()
    {
        xSpeed *= 1;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed * -5, ySpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Ballon"))
        {
            Helio.helio += 1; 
            Die();

        }
        else if ((col.gameObject.tag == "Limit"))
        {

            Die();

        }
        else if ((col.gameObject.tag == "blue ballon"))
        {
            Helio.helio += 10;
            Die();

        }

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
