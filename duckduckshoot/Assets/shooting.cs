using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shooting : MonoBehaviour
{


    public GameObject[] decals;
    public GameObject[] Scores;

    public TextMeshProUGUI m_Text;

    public int Score;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = "Score: " + Score.ToString();

    }

    public void spawnDecal(Vector3 pos, Transform parent, string sortingLayer)
    {
        int rand = Random.Range(0, decals.Length);
        GameObject DC = Instantiate(decals[rand], pos, Quaternion.identity, parent);
        DC.GetComponent<SpriteRenderer>().sortingLayerName = sortingLayer;
    }

    public void spawnScore(Vector3 pos, Transform parent, int ComboNumber)
    {
        if (ComboNumber <= 10)
        {
            Instantiate(Scores[0], pos, Quaternion.identity, parent);
            Score += 1;
        }

        if ((ComboNumber > 10) && (ComboNumber <= 20))
        { 
            Instantiate(Scores[1], pos, Quaternion.identity, parent);
            Score += 2;
        }

        if (ComboNumber > 20)
        {
            Instantiate(Scores[2], pos, Quaternion.identity, parent);
            Score += 3;
        }


    }

    public void onClickPlay()
    {
       
    }

}
