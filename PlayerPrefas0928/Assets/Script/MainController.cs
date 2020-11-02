using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null;
    private ContentController _Content = null;

    const string _Prefab = "Prefab/Button";
    int _Loop;

    [SerializeField] private Button _MyPageButton = null;
    // Start is called before the first frame update
    void Start()
    {
        Load();
        Debug.Log("Start");

        _MyPageButton.onClick.AddListener(MyPageButton);
        //for文でプレハブを生成を繰り返す（カウントアップ）
         for(int i = 0; i < 5; i++)
            {
                _Loop++;
                int index = i + 1;
                var Sprite = Resources.Load<Sprite>("Image/Story" + index.ToString()); //Imageのリソーシズロード
                var Prefab  = Instantiate<ContentController>(_Content, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform);
                Prefab.SetSprite(Sprite);
                Prefab.SetId(_Loop);

            }

        
        
    }
    void Load()
    {
        
        _Content = Resources.Load<ContentController>(_Prefab);  //Image
        Debug.Log("Load");
    }

    void MyPageButton()
    {
        SceneManager.LoadScene("MyPageScene");
    }
}

