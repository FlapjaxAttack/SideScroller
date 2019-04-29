using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDestroyer : MonoBehaviour
{

    public GameObject roadDespawnPoint;
    void Start()
    {
        roadDespawnPoint = GameObject.Find("ObjectDespawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < roadDespawnPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
