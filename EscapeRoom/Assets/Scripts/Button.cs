using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    [SerializeField] KeyCode key = KeyCode.Alpha1;
    char keyChar;
    public AudioClip clip;
    public AudioSource source;

    public void pushed()
    {
        source.Play();
        keyChar = System.Convert.ToChar(key);
        GetComponentInParent<keyPad>().SetPush(keyChar);

    }
}
