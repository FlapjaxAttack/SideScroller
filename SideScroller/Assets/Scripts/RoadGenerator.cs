using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject theRoad;
    public Transform generationPoint;
    public float distanceBetween;

    void Start()
    {
        
    }


    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(theRoad, transform.position, transform.rotation);
        }
    }
}
