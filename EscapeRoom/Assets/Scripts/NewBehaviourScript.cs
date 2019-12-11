using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string display;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public void update()
    {
        string str = null;
        string retString = null;
        str = "This is substring test";
        retString = str.Substring(5, 9);

        display = retString;
    }
}
