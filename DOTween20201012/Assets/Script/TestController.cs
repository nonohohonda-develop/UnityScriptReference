using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TestController : MonoBehaviour
{
    [SerializeField] private Button _Button1 = null;
    [SerializeField] private Button _Button2 = null;
    [SerializeField] private Button _Button3 = null;
    [SerializeField] private Button _Button4 = null;
    [SerializeField] private Button _Button5 = null; 
    




    
    void Start()
    {
        _Button1.onClick.AddListener(onClick1);
        _Button2.onClick.AddListener(onClick2);
         _Button3.onClick.AddListener(onClick3);
          _Button4.onClick.AddListener(onClick4);
           _Button5.onClick.AddListener(onClick5);
    

       transform.DOLocalMove(new Vector3(0, -590, 0), 0.5f);

        
    }

    void onClick1()
    {
    transform.DOLocalMove(new Vector3(-298, -590, 0), 0.5f);

    }

    void onClick2()
    {
        transform.DOLocalMove(new Vector3(-148, -590, 0), 0.5f);
    }
    void onClick3()
    {
       transform.DOLocalMove(new Vector3(0, -590, 0), 0.5f);
    }
    void onClick4()
    {
        transform.DOLocalMove(new Vector3(148, -590, 0), 0.5f);
    }
    void onClick5()
    {
        transform.DOLocalMove(new Vector3(298, -590, 0), 0.5f);
    }

    
}
