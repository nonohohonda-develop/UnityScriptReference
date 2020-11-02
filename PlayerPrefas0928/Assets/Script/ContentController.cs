using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContentController : MonoBehaviour
{
    public int id;
    [SerializeField] private Button _Button = null;
    //StoryContentのボタンの上の画像の宣言
    [SerializeField] private Image _Image = null;

    // Start is called before the first frame update
    void Start()
    {
        _Button.onClick.AddListener(OnClickButton);//イベント登録
    }

    void OnClickButton()
    {
        Debug.Log(id);
       PlayerPrefs.SetInt("id", id);
       SceneManager.LoadScene("PlayerPrefs");  //押すと飛ぶ
       Debug.Log("OnClickButton");
        
    } 
    public void SetId(int dataId)
    {
        id = dataId;


        
    }

    public void SetSprite(Sprite sprite)
    {
        Debug.Log(sprite);
        _Image.sprite = sprite;
    }
}
