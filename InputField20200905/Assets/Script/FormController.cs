using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FormController : MonoBehaviour
{
    //メンバー変数（UI)
    //名前
    [SerializeField] private InputField _NameInputField = null;

    //性別：男
    [SerializeField] private Toggle _ManToggle = null;
    //性別:女
    [SerializeField] private Toggle _WomanToggle = null;

    //メアド
    [SerializeField] private InputField _MailInputField = null;

    //ボタン
    [SerializeField] private Button _SubMitButton = null;
    //送信完了
    [SerializeField] private GameObject _SubmitText = null;
    
    public Dictionary<string, string> _FormData = new Dictionary<string, string>();

     


    
    // Start is called before the first frame update
    void Start()
    {
        this._SubmitText.SetActive(false);
        //Dictionary の追加
        _FormData.Add("name","");
        // _FormData.Add("sex_man","");
        // _FormData.Add("sex_woman","");
        _FormData.Add("sex", "");
        _FormData.Add("mail","");

        //ボタンイベントの登録
        if(_SubMitButton)
        {
            _SubMitButton.onClick.AddListener(OnClickButtonSubmit);
        }
    }

    private void OnClickButtonSubmit()
    {
        //入力した文字を出力
        Debug.Log(_NameInputField.text);
        Debug.Log(_MailInputField.text);
        //data key(name)に対してvalue(値)を確認
        Debug.Log(_FormData["name"]);
        Debug.Log(_FormData["mail"]);

        //名前
        //入力した文字が一文字でも入っていたら
        if(_NameInputField.text != "")
        {
            _FormData["name"] = _NameInputField.text;
        }

        //性別
        Debug.Log("_ManToggle :" + _ManToggle.isOn);
        Debug.Log("_WomanToggle :" + _WomanToggle.isOn);

        if(_ManToggle.isOn)
        {
            _FormData["sex"] = "man";
        }else if(_WomanToggle.isOn)
        {
            _FormData["sex"] = "woman";
        }else{
            _FormData["sex"] = "";
        }

        //mail
        if(_NameInputField.text != "")
        {
            _FormData["mail"] = _MailInputField.text;
        }


        // data key (neme)に対してvalue(値)を確認
        Debug.Log(_FormData["name"]);
        Debug.Log(_FormData["sex"]);
        Debug.Log(_FormData["mail"]);


        if(_FormData["name"] != "" && _FormData["sex"] != "" && _FormData["mail"] != "")

    

        {
            this._SubmitText.SetActive(true);
        }else{
            this._SubmitText.SetActive(false);
        }

        Debug.Log(_FormData);

    }

}
