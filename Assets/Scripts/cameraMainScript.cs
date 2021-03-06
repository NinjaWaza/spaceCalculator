using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMainScript : MonoBehaviour
{
    private GameObject ship;
    public int numberToReach;
    public GameObject numberToReachText;

    private int? currentBag;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Ship");
        numberToReachText = GameObject.Find("NumberToReachText");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.numberToReach.Equals(0))
        {
            RenewNumberToReach();
        }

        if (currentBag != null && currentBag == this.numberToReach)
        {
            //User earn a point
            //TODO : Increase use score by 1
            //We have to reset the currentBag and generate a new target number
            int numberToReachHistory = this.numberToReach;
            currentBag = null;
            RenewNumberToReach();
            while (this.numberToReach.Equals(numberToReachHistory))
            {
                RenewNumberToReach();
            }
            
            //If collision
            //
        }
    }

    public void RenewNumberToReach()
    {
        System.Random randomGenerator = new System.Random();

        int generatedNumber = randomGenerator.Next(10,50);
        this.numberToReach = generatedNumber;
        numberToReachText.GetComponent<UnityEngine.UI.Text>().text = this.numberToReach.ToString();
    }
}
