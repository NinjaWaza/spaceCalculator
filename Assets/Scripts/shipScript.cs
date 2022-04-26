using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipScript : MonoBehaviour
{
    private Renderer shipRenderer;
    private GameObject gazButton;
    private GameObject gameOverScreen;
    private GameObject wallOfFire;
    private GameObject numberToReachText;
    
    // Start is called before the first frame update
    void Start()
    {
        shipRenderer = this.gameObject.GetComponent<Renderer>();
        
        gazButton = GameObject.Find("GazButton");

        wallOfFire = GameObject.Find("WallOfFire");

        gameOverScreen = GameObject.Find("GameOverMessage");
        gameOverScreen.SetActive(false);
        
        numberToReachText = GameObject.Find("NumberToReachText");
    }

    // Update is called once per frame
    void Update()
    {
        if (!shipRenderer.isVisible)
        {
            Vector3 shipPosition = this.gameObject.transform.position;
            if (shipPosition.x <= -2.8f)
            {
                shipPosition.x = 2.8f;
            } else if (shipPosition.x >= 2.8f)
            {
                shipPosition.x = -2.8f;
            }
            this.gameObject.transform.position = shipPosition;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit detected, destruct the ship");
        
        if (other.gameObject == wallOfFire)
        {
            DisplayGameOver();
            gameObject.SetActive(false);
            numberToReachText.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
    
    public void DisplayGameOver()
    {
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }
}
