using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Week1 : MonoBehaviour
{

    // Start is called before the first frame update
   
    
    public string Win;
    public GameObject input;
    public GameObject output;

    public void tao()
    {
        Win = input.GetComponent<Text>().text;
        if (Win == "Unity")
        {
            output.GetComponent<Text>().text="[ Unity ] Is Found";
        }
        if (Win == "Unreal")
        {
            output.GetComponent<Text>().text = "[ Unreal ] Is Found";
        }
        if (Win == "Google")
        {
            output.GetComponent<Text>().text = "[ Google ] Is Found";
        }
        if (Win == "Line")
        {
            output.GetComponent<Text>().text = "[ Line ] Is Found";
        }
        if (Win == "Facebook")
        {
            output.GetComponent<Text>().text = "[ Facebook ] Is Found";
        }
        if (Win!= "Unity") 
        {
            output.GetComponent<Text>().text = "[         ]Is not Found";
        }
        
       
    }
        
    
}
