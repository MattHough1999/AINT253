using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Canvas clue;
    // Start is called before the first frame update
    
    public void pushed()
    {
        Quaternion target = Quaternion.Euler(0, 180, 0);

        // Dampen towards the target rotation
        transform.Rotate(new Vector3(180, 0, 0));
        clue.enabled = true;
        

    }
}
