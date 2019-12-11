using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManagerRoomOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        transform.GetChild(0).GetChild(2).gameObject.SetActive(false);
        transform.GetChild(0).GetChild(3).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
