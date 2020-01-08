using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keyPad : MonoBehaviour
{
    private string order = "1337";
    private string pushOrder = "xxxx";
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = pushOrder;
        if (pushOrder == order)
        {
            SceneManager.LoadScene("endGame");

        }
        if (!pushOrder.Contains("x")) 
        {
            pushOrder = "xxxx";
        }
    }

    public string SetPush(char pushed)
    {

        pushOrder = pushed.ToString() + pushOrder;

        pushOrder = pushOrder.Substring(0, 4);
        Debug.Log(pushOrder);
        return pushOrder;

    }
}
