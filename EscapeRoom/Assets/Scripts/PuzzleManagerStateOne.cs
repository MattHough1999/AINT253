using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManagerStateOne : MonoBehaviour
{
    public List<GameObject> podiums;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        podiums[GetComponentInChildren<Cubes>().active].SetActive(true);
    }
}
