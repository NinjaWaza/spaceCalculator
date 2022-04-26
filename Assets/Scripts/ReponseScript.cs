using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReponseScript : MonoBehaviour
{

    public string firstValue;
    public string op;
    public int scorePlayer;
    public string scorePlayerText;
    // Start is called before the first frame update
    void Start()
    {
        firstValue = "";
        op = "";
        scorePlayer = 0;
        scorePlayerText = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setFirstValue(string firstV){
        this.firstValue = firstV;
    }

    public void setOp(string ope){
        this.op = ope;
    }

    public string getOp(){
        return this.op;
    }

    public string getFirstValue(){
        return this.firstValue;
    }
}
