using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test3Controller : MonoBehaviour
{
    public GameObject Content = null;
    public GameObject Prefab = null;
    //public Sprite _Image = null;
    private List<string> List1 = new List<string>();
    

    // Start is called before the first frame update
    void Start()
    {
        //要素の追加
        List1.Add("Gohan1");
        List1.Add("Gohan2");
       
        
          for(int i = 0; i < List1.Count; i ++)
            {
            
            //Sprite inputSprite = Resources.Load<inputSprite>("Prefab/Image");
            GameObject Prefab = (GameObject)Resources.Load("Prefab/Text");
            var text = Prefab.GetComponent<Text>();
            text.text  = List1[i];
            Instantiate(Prefab,Vector3.zero,Quaternion.identity,Content.transform);
                
            }
            
    }

}
