using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fallingElementScript : MonoBehaviour
{
    public TextMeshPro value;
    private GameObject wallOfFire;
    public GameObject fallingElement;
    public GameObject fallingElement2;
    private GameObject ship;
    private GameObject actualNumber;
    private GameObject mainCamera;
    private GameObject reponse;
    private GameObject numberToReachText;
    private string firstValue;
    private string op;

    // Start is called before the first frame update
    void Start()
    {
        SetValue();
        ship = GameObject.Find("Ship");
        wallOfFire = GameObject.Find("WallOfFire");
        fallingElement = GameObject.Find("FallingElement");
        fallingElement2 = GameObject.Find("FallingElement2");
        actualNumber = GameObject.Find("ActualNumber");
        mainCamera = GameObject.Find("Main Camera");
        reponse = GameObject.Find("Reponse");
        numberToReachText = GameObject.Find("NumberToReachText");
    
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject == wallOfFire)
        {
            Reset();
        }
        else{

            if(this.value.text.Equals("+") || this.value.text.Equals("-")){
                reponse.GetComponent<ReponseScript>().setOp(this.value.text);
                actualNumber.GetComponent<UnityEngine.UI.Text>().text = reponse.GetComponent<ReponseScript>().getFirstValue() + this.value.text;
                SetValue2(reponse.GetComponent<ReponseScript>().getFirstValue());
            }
            else{
                if(reponse.GetComponent<ReponseScript>().getFirstValue().Equals("")){
                    reponse.GetComponent<ReponseScript>().setFirstValue(this.value.text);
                    actualNumber.GetComponent<UnityEngine.UI.Text>().text = this.value.text;
                    SendOperator();
                }
                else{
                    int v1 = int.Parse(this.reponse.GetComponent<ReponseScript>().getFirstValue());
                    int v2 = int.Parse(this.value.text);
                    int vfinal = 0;
                    if(this.reponse.GetComponent<ReponseScript>().getOp().Equals("+")){
                        vfinal = v1 + v2;
                    }
                    else{
                        vfinal = v1 - v2;
                    }
                    int vToReach = int.Parse(numberToReachText.GetComponent<UnityEngine.UI.Text>().text);
                    if( vfinal.Equals(vToReach)){
                        //reponse.GetComponent<UnityEngine.UI.Text>().text = "True";

                        this.reponse.GetComponent<ReponseScript>().scorePlayer += 1;
                        this.reponse.GetComponent<ReponseScript>().scorePlayerText = this.reponse.GetComponent<ReponseScript>().scorePlayer.ToString();
                        reponse.GetComponent<UnityEngine.UI.Text>().text = this.reponse.GetComponent<ReponseScript>().scorePlayerText;
                    }else{
                        //reponse.GetComponent<UnityEngine.UI.Text>().text = "False";
                        if(this.reponse.GetComponent<ReponseScript>().scorePlayer > 0){
                            this.reponse.GetComponent<ReponseScript>().scorePlayer -= 1;
                        }
                        this.reponse.GetComponent<ReponseScript>().scorePlayerText = this.reponse.GetComponent<ReponseScript>().scorePlayer.ToString();
                        this.reponse.GetComponent<UnityEngine.UI.Text>().text = this.reponse.GetComponent<ReponseScript>().scorePlayerText;
                    }
                    this.mainCamera.GetComponent<cameraMainScript>().RenewNumberToReach();
                    actualNumber.GetComponent<UnityEngine.UI.Text>().text = vfinal.ToString();
                    this.reponse.GetComponent<ReponseScript>().setFirstValue("");
                    this.reponse.GetComponent<ReponseScript>().setOp("");
                }
            }
            Reset();
        }
    }

    private void SetValue(){
        System.Random random = new System.Random();
        int number1 = random.Next(10,50);
        int number2 = random.Next(10,50);

        fallingElement.GetComponent<fallingElementScript>().SetValue(number1.ToString());
        fallingElement2.GetComponent<fallingElementScript>().SetValue(number2.ToString());
    }

    private void SetValue2(string firstValue){
        int vToReach = int.Parse(numberToReachText.GetComponent<UnityEngine.UI.Text>().text);
        int firstV = int.Parse(firstValue);
        int value2 = Mathf.Abs(vToReach - firstV);
        System.Random random = new System.Random();
        int number1 = random.Next(10,50);
        fallingElement.GetComponent<fallingElementScript>().SetValue(number1.ToString());
        fallingElement2.GetComponent<fallingElementScript>().SetValue(value2.ToString());
    }

    private void SendOperator(){
        fallingElement.GetComponent<fallingElementScript>().SetValue("+");
        fallingElement2.GetComponent<fallingElementScript>().SetValue("-");
    }

    private void Reset(){
        Vector3 fallingElementPosition = fallingElement.transform.position;
        Vector3 fallingElement2Position = fallingElement2.transform.position;

        fallingElementPosition.y = 4.49f;
        fallingElement2Position.y = 4.49f;

        fallingElement.transform.position = fallingElementPosition;
        fallingElement2.transform.position = fallingElement2Position;
    }

    public void SetValue(string v){
        this.value.text = v.ToString();
    }
}