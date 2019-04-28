using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController playerFocus;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    
    
    void Start()
    {
        playerFocus = FindObjectOfType<PlayerController>();
        lastPlayerPosition = playerFocus.transform.position;
    }

    
    void Update()
    {
        distanceToMove = playerFocus.transform.position.x - lastPlayerPosition.x;
        
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        
        lastPlayerPosition = playerFocus.transform.position;
        
    }
}
