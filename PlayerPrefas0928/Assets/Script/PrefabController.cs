using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabController : MonoBehaviour
{
    int i = 0;
    public Text _OutputText;  //inputFieldから受け取って表示されるテキスト

    void Start()
    {
        
        
        
        // transform.SetintSiblingIndex(i);
        // Debug.Log("Sibling Index : " + transform.GetSiblingIndex());
    }



    
     public void SetText(string text)  //Textはstring
    {
        
        Debug.Log(text);
        Debug.Log(_OutputText);
        _OutputText.text = text;  
    }
}
