using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class asteriodScript : MonoBehaviour
{
    private int rotationValue;
    // Start is called before the first frame update
    void Start()
    {
        System.Random randomRotationValue = new System.Random();
        rotationValue = randomRotationValue.Next(30,80);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0,0,rotationValue*Time.deltaTime);
    }
}
