using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{

    public GameObject[] ducksRight;
    public GameObject[] ducksLeft;
    public Vector3[] initposright;
    public Vector3[] initposleft;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        SpawnDuckR();
        SpawnDuckL();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDuckR();
            SpawnDuckL();
        }

    }

    public void SpawnDuckL()
    {
        Instantiate(ducksLeft[Random.Range(0, ducksLeft.Length - 1)], initposright[Random.Range(0, initposright.Length - 1)], Quaternion.identity);
    }

    public void SpawnDuckR()
    {
        Instantiate(ducksRight[Random.Range(0, ducksRight.Length - 1)], initposleft[Random.Range(0, initposleft.Length - 1)], Quaternion.identity);
    }
}
