using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "endGame" ) 
        {
            //btnResume.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            resume();
        }
    }
    public void resume() 
    {
        if(GetComponent<Canvas>().enabled == true) 
        {
            GetComponent<Canvas>().enabled = false;
        }
        else { GetComponent<Canvas>().enabled = true; }
    }
    public void levelOne() 
    {
        SceneManager.LoadScene("room1");
    }
    public void levelTwo()
    {
        SceneManager.LoadScene("room2");
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
