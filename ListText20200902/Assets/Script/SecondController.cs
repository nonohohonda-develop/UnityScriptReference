using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondController : MonoBehaviour
{
    public GameObject TextPrefab;
    public GameObject Content = null;

    // Start is called before the first frame update
    void Start()
    {
        List<string> myList = new List<string>() {"1105","2269","5784","4830"};
        for(int i = 0; i <myList.Count; i++)
        {
            GameObject prefab = (GameObject)Resources.Load("Prefab/Text");
            var text = prefab.GetComponent<Text>();
            text.text = myList[i];
            Instantiate(prefab,Vector3.zero,Quaternion.identity,Content.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
