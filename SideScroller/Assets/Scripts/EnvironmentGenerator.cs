using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour
{
    public GameObject debrisObj;
    public GameObject[] debrisObjs;
    public Transform generationPoint;
    public float distanceBetween;
    private float debWidth;
    public float distanceBetweenMin;
    public float distanceBetweenMax;
    private int debrisSelection;

    //public ObjectPooler theObjectPool;

    void Start()
    {
        debWidth = debrisObj.GetComponent<BoxCollider2D>().size.x;
    }


    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            
            transform.position = new Vector3(transform.position.x + distanceBetween, transform.position.y, transform.position.z);

            Instantiate( /*debrisObj,*/ debrisObjs[debrisSelection], transform.position, transform.rotation);

            debrisSelection = Random.Range(0, debrisObjs.Length);

            /* GameObject newDebris = theObjectPool.GetPooledObject();

            newDebris.transform.position = transform.position;
            newDebris.transform.rotation = transform.rotation;
            newDebris.SetActive(true);
            */
        }
    }
}
