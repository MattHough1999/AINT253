using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podiumPush : MonoBehaviour
{
    public GameObject player;
    [SerializeField] KeyCode key = KeyCode.R;
    char keyChar;
    // Start is called before the first frame update
    void Start()
    {
        keyChar = System.Convert.ToChar(key);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(key)) 
        {
            Debug.Log(keyChar.ToString());
            GetComponentInParent<Podiums>().SetPush(keyChar);
            
        }
    }
}
