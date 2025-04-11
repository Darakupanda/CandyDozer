using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    Vector3 startPosistion;

    public float amplitude;
    public float speed;

    void Start()
    {
        startPosistion = transform.localPosition;        
    }

    void Update()
    {
        float z = amplitude * Mathf.Sin(Time.time * speed);
        transform.localPosition = startPosistion + new Vector3(0,0,z);  
    }
}
/***
// プロパティの追加
class Hero{
    String name;
    int hp;

    public string Name{
        set{this.name=value;}
        get{return this.name;}
    }
    
    public int Hp{
        set{this.name=value;}
        get{return this.hp;}
    }
    h.Hp = 10;
}
class wizard{
    public string Name{get;set;}
    //w.Name="ポップ";
}
class Transform{
    private Vector3 position;
    public void setPosition(Vector3 position){
        this.position=position;
    }   
}
class Transform{
    private Vector3 potision;
    public Vector3 position{
        set{this.position = value;}
        get{return this.position;}
    }
}
***/
