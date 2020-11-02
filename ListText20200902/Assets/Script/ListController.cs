using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ListController : MonoBehaviour
{
    //コンテンツについて
   
    //[SerializeField] private Text _Text = null;
    public GameObject TextPrefab;
    public GameObject Content = null;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        List<string> ListText = new List<string>() {"瑞巌寺","二条城","東大寺","東本願寺","永平寺","龍安寺","長光寺"};
       


        for (int i = 0; i < ListText.Count; i++)
        {
            //_Text.text += ListText[i];
            GameObject prefab = (GameObject)Resources.Load ("Prefab/Text");
            var text = prefab.GetComponent<Text>();
            text.text = ListText[i];
            Instantiate (prefab,Vector3.zero, Quaternion.identity,Content.transform);


            //  var text = (Text)Resources.Load ("Prefab/Text");
            // // var text = prefab.getComponent<Text>();
            // text.text = "aaaaa";

            // Instantiate (text.gameObject, TextPrefab, TextPrefab, content_transform);

            
            //prefab = Instantiate (TextPrefab, TextPrefab, TextPrefab, TextPrefab);
            // Debug.Log(ListText[i]);
        }



    
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
