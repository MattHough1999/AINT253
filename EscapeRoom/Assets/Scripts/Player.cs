using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        //Text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        lookAt();
    }
    public void lookAt()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 3, Color.red);
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f))
        {
            //Text.text = "E";
            //Debug.Log(hit.transform.name);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(hit.transform.tag == "Cube") 
                {
                    hit.transform.GetComponent<Cube>().pickup();
                    //hit.transform.GetComponent<Cubes>().Cubed();
                }
                else if(hit.transform.tag == "Podium") 
                {
                    hit.transform.GetComponent<podiumPush>().pushed();
                }
                else if (hit.transform.tag == "Button")
                {
                    hit.transform.GetComponent<Button>().pushed();
                }
                else if (hit.transform.tag == "Switch")
                {
                    hit.transform.GetComponent<Switch>().pushed();
                }
                //if(TryGetComponent<>)
            }
        }
    }
}
