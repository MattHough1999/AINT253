using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    public AudioSource source;
    public void pickup() 
    {
        GetComponentInParent<Cubes>().active++;
        source.Play();
        Destroy(gameObject);
    }
}
