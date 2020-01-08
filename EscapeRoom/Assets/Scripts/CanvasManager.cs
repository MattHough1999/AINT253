using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public bool boolean = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "endGame" ) 
        {
            //btnResume.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(boolean == true) { Cursor.visible = true; Cursor.lockState = CursorLockMode.None; }
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            resume();
        }
        if (Input.GetKeyDown(KeyCode.R)) levelOne();
    }
    public void resume() 
    {
        
        if (GetComponent<Canvas>().enabled == true) 
        {
            boolean = false;
            GetComponent<Canvas>().enabled = false;
        }
        else { GetComponent<Canvas>().enabled = true; Cursor.visible = true; boolean = true; }
    }
    public void levelOne() 
    {
        SceneManager.LoadScene("Room1");
    }
    public void levelTwo()
    {
        SceneManager.LoadScene("Room2");
    }
    public void returnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exitGame() 
    {
        Application.Quit();
    }
    
}
