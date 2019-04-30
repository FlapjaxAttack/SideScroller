using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public Transform objGenerator;
    private Vector3 gameStartPoint;
    public PlayerController thePlayer;
    private Vector3 playerStartPoint;
    void Start()
    {
        gameStartPoint = objGenerator.position;
        playerStartPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        thePlayer.transform.position = playerStartPoint;
        objGenerator.position = gameStartPoint;
        thePlayer.gameObject.SetActive(true);
    }
}
