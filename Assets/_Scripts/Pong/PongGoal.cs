using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongGoal : MonoBehaviour
{
    public ScoreManager manager;
    public int playerScoredOn = 1;


    private void OnTriggerEnter(Collider other)
    {
        manager.AddPoint(playerScoredOn);
    }
}
