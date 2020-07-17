using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerR : MonoBehaviour
{

    public DuckSpawner ds;
    public dianaSpawn dis;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log(collision.gameObject.name);

        if (collision.tag == "Duck")
        {
            ds.SpawnDuckR();
            dis.Spawndiana();
        }


    }
}