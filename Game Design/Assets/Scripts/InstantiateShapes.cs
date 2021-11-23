using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateShapes : MonoBehaviour
{
    public GameObject myPrefab;
    Vector3 originalPos;
    float radius;
    int layerMask;
    Scores result;
    
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        radius = 0.5f;
        layerMask=1;
        result = GameObject.FindGameObjectWithTag("Player").GetComponent<Scores>();
    }

    void Update()
    {
        if (!Physics2D.OverlapCircle(originalPos, radius, layerMask)) {
            Spawn();
            result.areaCoveredCheck();
        }      
    }

    // for instantiating prefabs
    private void Spawn(){
        GameObject a = Instantiate(myPrefab, originalPos , Quaternion.identity) as GameObject;
        result.items_used++;
        result.newItemUsedCheck();
        result.change_items_used.text = level.items_used.ToString();
    }
}
