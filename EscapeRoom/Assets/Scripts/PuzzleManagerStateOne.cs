using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManagerStateOne : MonoBehaviour
{
    public List<GameObject> podiums;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        count = GetComponentInChildren<Cubes>().active;
        if (podiums.Count > count)
        podiums[count].SetActive(true);
    }
}
