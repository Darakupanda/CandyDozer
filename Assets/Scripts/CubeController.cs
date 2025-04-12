using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 vec = Vector3.zero;
    Coroutine corrent;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(ChangeAxis()); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vec);
        if(Input.GetMouseButtonDown(0)){
            StopCoroutine(corrent);
            vec = Vector3.zero;
        }
    }
    IEnumerator ChangeAxis(){
        while(true){
            yield return new WaitForSeconds(2.0f);
            vec.z = 0f;
            vec.y = 1f;
            yield return new WaitForSeconds(2.0f);
            vec.y = 0f;
            vec.x = 1f;
            yield return new WaitForSeconds(2.0f);
            vec.x = 0f;
            vec.z = 1f;
        }
    }
}
