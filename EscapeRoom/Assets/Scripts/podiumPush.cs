using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podiumPush : MonoBehaviour
{
    public GameObject player;
    [SerializeField] KeyCode key = KeyCode.R;
    char keyChar;
    public void pushed()
    {
        keyChar = System.Convert.ToChar(key);

        if (Input.GetKeyDown(key)) 
        {
            Debug.Log(keyChar.ToString());
            GetComponentInParent<Podiums>().SetPush(keyChar);
            
        }
    }
}
