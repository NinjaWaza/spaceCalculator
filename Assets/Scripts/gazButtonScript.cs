using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gazButtonScript : MonoBehaviour
{
    private GameObject ship;
    private bool isPressed;
    private bool leftButtonIsPressed;
    private bool rightButtonIsPressed;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Ship");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 shipPosition = ship.transform.position;
        shipPosition.y -= 0.0015f;
        ship.transform.position = shipPosition;
        if (isPressed)
        {
            forwardShip();
        }
        
        if (leftButtonIsPressed)
        {
            moveShipToLeft();
        }
        
        if (rightButtonIsPressed)
        {
            moveShipToRight();
        }
    }

    public void moveShipToLeft()
    {
        Vector3 shipPosition = ship.transform.position;
        shipPosition.x -= 0.015f;
        ship.transform.position = shipPosition;
    }
    
    public void moveShipToRight()
    {
        Vector3 shipPosition = ship.transform.position;
        shipPosition.x += 0.015f;
        ship.transform.position = shipPosition;
    }
    
    
    public void forwardShip()
    {
        Vector3 shipPosition = ship.transform.position;
        shipPosition.y += 0.01f;
        ship.transform.position = shipPosition;
    }

    public void buttonPressed()
    {
        isPressed = true;
    }
    
    public void buttonReleased()
    {
        isPressed = false;
    }
    
    public void leftButtonPressed()
    {
        leftButtonIsPressed = true;
    }
    
    public void leftButtonReleased()
    {
        leftButtonIsPressed = false;
    }
    
    public void rightButtonPressed()
    {
        rightButtonIsPressed = true;
    }
    
    public void rightButtonReleased()
    {
        rightButtonIsPressed = false;
    }
}
