using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestController : MonoBehaviour
{
   
     //メンバー変数（UI)
    //Music
    [SerializeField] private InputField _MusicInputField = null;
    //Food
    [SerializeField] private InputField _FoodInputField = null;
    //GoOut
    [SerializeField] private InputField _GOInputField = null;
    //BirthDay
    [SerializeField] private InputField _BDInputField = null;

    //保存ボタン
    [SerializeField] private Button _SaveButton = null;
    //保存完了(CheckMark)
    [SerializeField] private GameObject _CheckImage = null;
    
    public Dictionary<string, string> _FavData = new Dictionary<string, string>();

    //戻るボタン
     [SerializeField] private Button _BuckSceneButton = null;


    // Start is called before the first frame update
    void Start()
    {
        this._CheckImage.SetActive(false);

        //Dictionary の追加
        _FavData.Add("Music","");
        _FavData.Add("Food" ,"");
        _FavData.Add("G.O","");
        _FavData.Add("B.D","");

        //保存ボタンイベントの登録
        if(_SaveButton)
        {
            _SaveButton.onClick.AddListener(OnClickButtonSave);
        }

        //戻るボタンのイベント登録
        if(_BuckSceneButton)
        {
            _BuckSceneButton.onClick.AddListener(OnClickButtonBuckScene);
        }

        
    }
    private void OnClickButtonSave()
    {
        //入力した文字を出力
        Debug.Log(_MusicInputField.text);
        Debug.Log(_FoodInputField.text);
        Debug.Log(_GOInputField.text);
        Debug.Log(_BDInputField.text);

        //data key(name)に対してvalue(値)を確認
        Debug.Log(_FavData["Music"]);
        Debug.Log(_FavData["Food"]);
        Debug.Log(_FavData["G.O"]);
        Debug.Log(_FavData["B.D"]);

       

        //Music
        //入力した文字が一文字でも入っていたら
        if(_MusicInputField.text != "")
        {
            _FavData["Music"] = _MusicInputField.text;
        }

        //Food
        //入力した文字が一文字でも入っていたら
        if(_FoodInputField.text != "")
        {
            _FavData["Food"] = _FoodInputField.text;
        }

        //GoOut
        //入力した文字が一文字でも入っていたら
        if(_GOInputField.text != "")
        {
            _FavData["G.O"] = _GOInputField.text;
        }

        //BirthDay
        //入力した文字が一文字でも入っていたら
        if(_BDInputField.text != "")
        {
            _FavData["B.D"] = _BDInputField.text;
        }

        // data key (neme)に対してvalue(値)を確認
        Debug.Log(_FavData["Music"]);
        Debug.Log(_FavData["Food"]);
        Debug.Log(_FavData["G.O"]);
        Debug.Log(_FavData["B.D"]);
        


        if(_FavData["Music"] != "" && _FavData["Food"] != "" && _FavData["G.O"] != "" && _FavData["B.D"] != "")

    

        {
            this._CheckImage.SetActive(true);
        }else{
            this._CheckImage.SetActive(false);
        }

        Debug.Log(_FavData);

    }

    private void OnClickButtonBuckScene()
    {
        SceneManager.LoadScene("FormScene");
    }
}
