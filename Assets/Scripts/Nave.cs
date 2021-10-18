using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        rbd =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Helio.helio <= 0)
        {
            rbd.gravityScale = 3;
        }
    }
}
