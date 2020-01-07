using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podiums : MonoBehaviour
{
    private string order = "borg"; 
    private string pushOrder = "xxxx";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pushOrder == order) 
        {
            GetComponentInParent<PuzzleManager>().changeState();
        }
    }
    
    public string SetPush(char pushed) 
    { 
        
        pushOrder = pushed.ToString() + pushOrder;

        pushOrder = pushOrder.Substring(0, 4);
        return pushOrder;
    }
}
