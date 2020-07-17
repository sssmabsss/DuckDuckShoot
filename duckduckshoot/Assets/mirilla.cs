using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mirilla : MonoBehaviour
{

    public Vector3 MousePos;
    public Vector3 screenpos;
    public Camera cam;
    public string SL;
    public bool isComboActive;
    public int hits;


    public shooting shot;

    public TextMeshProUGUI m_Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Input.mousePosition;
        MousePos.z = 10;
        screenpos = cam.ScreenToWorldPoint(MousePos);

        m_Text.text = "Combo: " + hits.ToString();

        transform.position = screenpos;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(screenpos, Vector2.zero);
            if (hit.collider != null)
            {
                isComboActive = true;

                SL = hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
                Debug.Log(hit.collider.gameObject.GetComponent<enemy>().health);
                if (hit.collider.gameObject.GetComponent<enemy>().health > 0)
                {
                    hits++;
                    shot.spawnDecal(screenpos, hit.collider.gameObject.transform, SL);
                    shot.spawnScore(screenpos, hit.collider.gameObject.transform, hits);
                    hit.collider.gameObject.GetComponent<enemy>().health--;

                }


            }
            else isComboActive = false;
                
        }

        combo();

    }


    public void combo()
    {
        if (!isComboActive)
        {
            hits = 0;
        }
    }
}
