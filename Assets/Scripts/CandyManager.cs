using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CandyManager : MonoBehaviour
{
    const int DefaultCandyAmount = 30;
    const int RecoverySeconds = 10;
    public TextMeshProUGUI candyUI;
    int counter;
    int candy = DefaultCandyAmount;

    void Start()
    {
        UpdateUI();
    }

    void Update()
    {
        if(candy < DefaultCandyAmount && counter <= 0){
            StartCoroutine(RecoverCandy());
        }
    }

    public int Candy{
        get{return this.candy;}
    }
    
    public void ConsumeCandy(){
        if(candy > 0) candy--;
        UpdateUI();
    }

    void UpdateUI(){
        string cnt = "";
        if(counter > 0){
            cnt = $"({counter}s)";
        }
        candyUI.text = $"Candy : {candy}{cnt}";
    }

    // public int GetCandyAmount(){
    //     return candy;
    // }

    public void AddCandy(int amount){
        candy += amount;
        UpdateUI();
    }

    // void OnGUI()
    // {
    //     GUI.color = Color.black;
    //     string label = "Candy :" + candy;
    //     GUI.Label(new Rect(50,50,100,30),label);
    //     if(counter > 0) label = label+"(" + counter + "s)";
    // }

    IEnumerator RecoverCandy(){
        counter = RecoverySeconds;
        UpdateUI();
        while(counter > 0){
            yield return new WaitForSeconds(1.0f);
            counter--;
            UpdateUI();
        }
        AddCandy(1);
    }
}
