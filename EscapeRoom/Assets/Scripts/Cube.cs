using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public void pickup() 
    {
        GetComponentInParent<Cubes>().active++;
        Destroy(gameObject);
    }
}
