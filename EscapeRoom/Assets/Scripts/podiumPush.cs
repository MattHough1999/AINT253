using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podiumPush : MonoBehaviour
{
    public GameObject player;
    [SerializeField] KeyCode key = KeyCode.R;
    public AudioClip clip;
    public AudioSource source;
    char keyChar;
    public void pushed()
    {
        source.Play();
        keyChar = System.Convert.ToChar(key);
        GetComponentInParent<Podiums>().SetPush(keyChar);
        
    }
}
