using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rate;
    public GameObject[] globos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBallon", rate, rate);
    }

    // Update is called once per frame
    void SpawnBallon()
    {
        Instantiate(globos[Random.Range(0, globos.Length)], new Vector3(Random.Range(-4f, 5f), -9, 0), Quaternion.identity);
    }
}
