using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test2Controller : MonoBehaviour
{
    //小学校
    [SerializeField] private InputField _ESInputField = null;
    
    //中学校
    [SerializeField] private InputField _JHSInputField = null;
    //高校
    [SerializeField] private InputField _HSInputField = null;
     //保存ボタン
    [SerializeField] private Button _SaveButton = null;


    //Dictionary 型
    public Dictionary<int, int> _SchollData = new Dictionary<int, int>();

    



    // Start is called before the first frame update
    void Start()
    {
        _SchollData.Add(1, 1);
        _SchollData.Add(2, 2);
        _SchollData.Add(3, 3);

        //ボタンイベントの登録
        if(_SaveButton)
        {
            _SaveButton.onClick.AddListener(OnClickButtonSave);
        }
        
    }

    private void OnClickButtonSave()
    {
        //入力した文字を出力
        Debug.Log(_ESInputField.text);
        Debug.Log(_JHSInputField.text);
        Debug.Log(_HSInputField.text);

        //入力した文字が一文字でも入っていたら
        if(_ESInputField.text != null)
        {
            _SchollData[1] = int.Parse(_ESInputField.text);
            
            

        }

        if(_JHSInputField.text != null)
        {
            _SchollData[2] = int.Parse(_JHSInputField.text);
           
            
        }

        if(_HSInputField.text != null)
        {
            _SchollData[3] = int.Parse(_HSInputField.text);
           
            
        }

        // data key (neme)に対してvalue(値)を確認
        Debug.Log("小学校卒業:" + _SchollData[1]);
        Debug.Log("中学校卒業 :" + _SchollData[2]);
        Debug.Log("高校卒業:" + _SchollData[3]);

        //if(_SchollData[1] != "" && _SchollData[2] != "" && _SchollData[3] != "")
        
    }
}
