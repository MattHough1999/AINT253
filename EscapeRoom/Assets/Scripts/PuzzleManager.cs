using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject stateOne;
    public GameObject stateTwo;
    // Start is called before the first frame update
    void Start()
    {
        stateOne.SetActive(true);
        stateTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeState() 
    {
        stateTwo.SetActive(true);
        stateOne.SetActive(false);
    }
}
