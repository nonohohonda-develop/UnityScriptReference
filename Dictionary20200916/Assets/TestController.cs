using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour
{
    private Text text;
     //コンテンツ(ScrollView)
   [SerializeField] private GameObject _ScrollContent = null;
   private ReciveObjectController _PrefabReciveContent = null;
   const string _FromReciveObject = "Prefab/ReceiveObject";
    [SerializeField] private Button _Button = null;
    void Start()
    {
        _Button.onClick.AddListener(OnClickButton);
        
    }

    private void OnClickButton()
    {
    
       Dic();


    
    }

    void Dic()
    {
        _PrefabReciveContent = Resources.Load<ReciveObjectController>(_FromReciveObject);
        var PrefabReciveObject  = Instantiate<ReciveObjectController>(_PrefabReciveContent, Vector3.zero, Quaternion.identity, _ScrollContent.transform);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
