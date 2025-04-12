using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrefab;
    public Vector3 effectRotation;

    void OnTriggerEnter(Collider other)
    {
        if((other.CompareTag("Candy"))){
            candyManager.AddCandy(reward);
            Destroy(other.gameObject);

            if(effectPrefab != null){
                Instantiate(
                    effectPrefab,
                    other.transform.position+Vector3.up*Random.Range(0.8f,1.3f),
                    Quaternion.Euler(effectRotation)
                );
            }
        }   
    }
}
