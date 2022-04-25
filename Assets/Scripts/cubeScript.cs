using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    private int value;
    private string operatorAsString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.gameObject.transform.position;
        position.y -= 0.03f;
        this.gameObject.transform.position = position;
    }
}
