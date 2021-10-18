using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helio : MonoBehaviour
{
    public static double helio = 15;
    public Text printHelio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        printHelio.text = $"{helio}";
    }
}
