using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public List<Vector3> positions = new List<Vector3>();
    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Area");
        foreach (var gameObject in objects) 
        {
            positions.Add(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
        }

    }

}
