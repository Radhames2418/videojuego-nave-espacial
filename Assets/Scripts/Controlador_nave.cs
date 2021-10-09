using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_nave : MonoBehaviour
{
    public float velocidad = 3f;
    public GameManager gameManager;
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Limit")
        {
            gameManager.gameOver = true;
        }
    }
}
