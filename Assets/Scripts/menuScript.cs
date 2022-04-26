using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class menuScript : MonoBehaviour
{
	private GameObject menuOpenButton;
	private GameObject menuCloseButton;
	private GameObject menu;
    private bool OpenIsPressed;
    private bool CloseIsPressed;

    // Start is called before the first frame update
    void Start()
    {

    	menuOpenButton = GameObject.Find("MenuOpenButton");
		menuCloseButton = GameObject.Find("MenuCloseButton");
		menu = GameObject.Find("Menu");


        /*menu.SetActive(true);
        menuOpenButton.SetActive(true);*/
        Time.timeScale = 0;
        OpenIsPressed = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (OpenIsPressed)
        {
        	PauseGame();
        }

        if (CloseIsPressed)
        {
        	ResumeGame();
        }
    }
    

    public void OpenbuttonPressed()
    {
        OpenIsPressed = true;
    }

    public void ClosebuttonPressed()
    {
        CloseIsPressed = true;
    }

    public void PauseGame()
    {
        menu.SetActive(true);
    	menuOpenButton.SetActive(false);
        menuCloseButton.SetActive(true);
        OpenIsPressed = false;
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        menu.SetActive(false);
        menuOpenButton.SetActive(true);
        menuCloseButton.SetActive(false);
        CloseIsPressed = false;
        Time.timeScale = 1;
    }
}
