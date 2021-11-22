using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateShapes : MonoBehaviour
{
    public GameObject myPrefab;
    Vector3 originalPos;
    float radius;
    int layerMask;
    Scores level;

    //  public GameObject items;
    
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        radius = 0.5f;
        layerMask=1;
        level = GameObject.FindGameObjectWithTag("Player").GetComponent<Scores>();
    }

    void Update()
    {
        if (!Physics2D.OverlapCircle(originalPos, radius, layerMask)) {
            Spawn();
            // Debug.Log("Spawn");
        }      
    }

    private void Spawn(){
        GameObject a = Instantiate(myPrefab, originalPos , Quaternion.identity) as GameObject;
        level.items_used++;

        if(level.items_used>level.min_items) level.scores=level.max_scores-(level.items_used-level.min_items)*10;
        
        Debug.Log(level.scores);
        level.change_items_used.text = level.items_used.ToString();
    }
}
