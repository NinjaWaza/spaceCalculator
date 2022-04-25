using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipScript : MonoBehaviour
{
    private Renderer shipRenderer;
    private GameObject gazButton;
    
    // Start is called before the first frame update
    void Start()
    {
        shipRenderer = this.gameObject.GetComponent<Renderer>();
        gazButton = GameObject.Find("GazButton");
        
        shipRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!shipRenderer.isVisible)
        {
            Vector3 shipPosition = this.gameObject.transform.position;
            shipPosition.x = 0;
            this.gameObject.transform.position = shipPosition;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit detected, destruct the ship");
        Destroy(this.gameObject);
        /*
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);
        */
    }
}
