using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;

    void OnTriggerEnter(Collider other)
    {
        if((other.CompareTag("Candy"))){
            candyManager.AddCandy(reward);
            Destroy(other.gameObject);
        }   
    }
}
