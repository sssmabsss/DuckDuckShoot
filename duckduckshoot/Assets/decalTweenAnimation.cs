using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decalTweenAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.FadeTo(gameObject,  0f, 5.75f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
