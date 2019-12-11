using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podiums : MonoBehaviour
{
    private string order = "borg"; //resistance is futile. join the collective.
    private string pushOrder = "bbbb";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pushOrder == order) 
        {
            openDoor();        
        }
        
      //this is where matt was a nonce
    }
    public void openDoor() 
    {
        
    }
    public string SetPush(char pushed) 
    { 
        
        pushOrder = pushed.ToString() + pushOrder;

        pushOrder = pushOrder.Substring(0, 4);
        return pushOrder;
    }
}
