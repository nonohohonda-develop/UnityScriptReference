using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加しましょう
using UnityEngine.SceneManagement;
 
public class ScoreManager : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _Text = null;  //このテキストが各IDによって違う
    [SerializeField] private Image _Image = null; //このImageが各IDによって違う
    [SerializeField] private Button _Button = null; //戻るボタン
     
    

       Dictionary<int,string> _Names = new Dictionary<int, string>();
      Dictionary<int,Sprite> _Images = new Dictionary<int, Sprite>();
 
 
    
      // 初期化
      void Start () 
      {
         _Button.onClick.AddListener(OnClickBuckButton);  //戻るボタン

         int id = PlayerPrefs.GetInt("id");
         //Dictionary
        _Images.Add(1,Resources.Load<Sprite>("Image/Story1"));
        _Images.Add(2,Resources.Load<Sprite>("Image/Story2"));
        _Images.Add(3,Resources.Load<Sprite>("Image/Story3"));
        _Images.Add(4,Resources.Load<Sprite>("Image/Story4"));
        _Images.Add(5,Resources.Load<Sprite>("Image/Story5"));

        _Names.Add(1,"_Lisa");
        _Names.Add(2,"_Selena");
        _Names.Add(3,"_Jisoo");
        _Names.Add(4,"_Rose");
        _Names.Add(5,"_Jennie");

        
        Debug.Log("id" + id);

        _Text.text = _Names[id];
        _Image.sprite = _Images[id];
        
        Debug.Log(_Names[id]);

        Debug.Log(_Images[id]);
        

      }
    void OnClickBuckButton()
    {
      SceneManager.LoadScene("MainScene");
      Debug.Log("OnClickBuckButton");
    }
 
}