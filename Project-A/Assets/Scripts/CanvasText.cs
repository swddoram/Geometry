using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasText : MonoBehaviour
{
    public Text TextBox1;
    public string Text1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextBox1.text = Text1;                      
    }
}
