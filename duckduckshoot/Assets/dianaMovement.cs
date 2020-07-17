using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dianaMovement : MonoBehaviour
{

    public iTween.EaseType[] easytypes;



    // Start is called before the first frame update
    void Start()
    {

        iTween.MoveBy(gameObject, iTween.Hash("y", Random.Range(2.25f, 6f), "time", 1, "easeType", easytypes[Random.Range(0, easytypes.Length - 1)], "delay", .1));
        iTween.MoveTo(gameObject, iTween.Hash("y", -5, "time", 1, "easeType", easytypes[Random.Range(0, easytypes.Length - 1)], "delay", Random.Range(2, 7f), "oncomplete", "despawn"));

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void despawn()
    {
        Destroy(gameObject);
    }
        
}
