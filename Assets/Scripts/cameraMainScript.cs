using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMainScript : MonoBehaviour
{
    private GameObject ship;
    private int numberToReach;

    private int? currentBag;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Ship");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.numberToReach == null)
        {
            renewNumberToReach();
        }

        if (currentBag != null && currentBag == this.numberToReach)
        {
            //User earn a point
            //TODO : Increase use score by 1
            //We have to reset the currentBag and generate a new target number
            int numberToReachHistory = this.numberToReach;
            currentBag = null;
            renewNumberToReach();
            while (this.numberToReach.Equals(numberToReachHistory))
            {
                renewNumberToReach();
            }
            
            //If collision
            //
        }
    }

    void renewNumberToReach()
    {
        System.Random randomGenerator = new System.Random();

        int generatedNumber = randomGenerator.Next(10,100);
        this.numberToReach = generatedNumber;
    }
}
