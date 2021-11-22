using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public List<Vector2> positions = new List<Vector2>();
    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Area");
        foreach (var gameObject in objects) 
        {
            positions.Add(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));
        }

    }

}
