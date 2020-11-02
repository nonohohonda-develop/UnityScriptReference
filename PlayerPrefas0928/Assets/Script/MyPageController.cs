using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyPageController : MonoBehaviour
{
    //InputFieldを格納するための変数
    //オブジェクトと結びつける
    public InputField inputField;

    private Text text;
    //コンテンツ(ScrollView)
   [SerializeField] private GameObject _ScrollContent = null;

   //PrefabContent
   private PrefabController _PrefabContent = null;
   const string _From = "Prefab/TweetObj";

   //送信ボタン
    [SerializeField] private Button _Button = null;
    [SerializeField] private Button _BuckMainButton = null;
    // Start is called before the first frame update
    void Start()
    {
        
        
         _Button.onClick.AddListener(OnClickButton);  //イベント登録
         _BuckMainButton.onClick.AddListener(OnClickMainButton);

         if(inputField.text != "")   //中身に何か入っていれば処理ができる
       {
           OnClickButton();
       }
        
    }

    //送信ボタンの処理メゾット
     private void OnClickButton()
    {

       Debug.Log(inputField.text);

       Load();

       
      
        inputField = inputField.GetComponent<InputField> ();
        inputField.text = ""; //inputField内のテキストをボタン送信後に空にする
        
    
    }
    void Load()
    {

        //ResourcesLoad
        _PrefabContent = Resources.Load<PrefabController>(_From);
        //Instantiate
        var Prefab  = Instantiate<PrefabController>(_PrefabContent, Vector3.zero, Quaternion.identity, _ScrollContent.transform);

        Prefab.transform.SetSiblingIndex(0);

        

        Prefab.SetText(inputField.text); 

        Debug.Log("Load");
       
    }

    void OnClickMainButton()  //戻るボタン
    {
         SceneManager.LoadScene("MainScene");
    }
}
