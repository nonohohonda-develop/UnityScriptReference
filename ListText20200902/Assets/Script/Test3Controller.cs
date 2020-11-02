using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestController : MonoBehaviour
{
    public GameObject Content = null;
    public GameObject Prefab = null;

    private List<string> mylist = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        mylist.Add("友よ〜この先もずっと");
        mylist.Add("NONTiE-UP");
        mylist.Add("TroubleMaker");
        mylist.Add("BeautifulWreck");
        mylist.Add("LoveMeLess");
        mylist.Add("HowYouLikeThat");
        mylist.Add("WannaBe");
        mylist.Add("LetYouGo");
    

        for(int i = 0; i < mylist.Count; i++)
        {
            GameObject Prefab = (GameObject)Resources.Load("Prefab/Text2");
            var text = Prefab.GetComponent<Text>();
            text.text = text.text  = mylist[i];
            Instantiate(Prefab,Vector3.zero,Quaternion.identity,Content.transform);
        }        
        
        
    }


}
