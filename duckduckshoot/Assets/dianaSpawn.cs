using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dianaSpawn : MonoBehaviour
{

    public GameObject[] dianas;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        Spawndiana();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawndiana();
        }
    }

    public void Spawndiana()
    {
        Instantiate(dianas[Random.Range(0, dianas.Length - 1)], new Vector3(Random.Range(-7.3f,9.5f),-5,0), Quaternion.identity);
    }
}
