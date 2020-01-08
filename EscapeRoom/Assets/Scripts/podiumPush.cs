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
        GetComponentInParent<Podiums>().SetPush(keyChar);
        
    }
}
