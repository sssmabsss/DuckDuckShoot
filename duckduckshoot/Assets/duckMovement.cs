using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckMovement : MonoBehaviour
{

    public bool facingForward;
    public int time;
    public iTween.EaseType easytype;


    // Start is called before the first frame update
    void Start()
    {
        if (facingForward) iTween.MoveBy(gameObject, iTween.Hash("x", 30, "time",time , "easeType", easytype, "delay", .1));
        if (!facingForward) iTween.MoveBy(gameObject, iTween.Hash("x", -30, "time",time , "easeType", easytype, "delay", .1));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
