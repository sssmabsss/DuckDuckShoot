using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTweenAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.MoveBy(gameObject, iTween.Hash("y", Random.Range(.3f, 1.2f), "time", .75, "easeType", iTween.EaseType.spring, "delay", .1, "oncomplete", "despawn"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void despawn()
    {
        iTween.FadeTo(gameObject,  0f, .75f);
    }
}
