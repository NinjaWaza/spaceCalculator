using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public GameObject circle;

    private int numberOfCircle;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCircle = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfCircle < 10)
        {
            Instantiate(circle);
            numberOfCircle++;
        }
    }
}
