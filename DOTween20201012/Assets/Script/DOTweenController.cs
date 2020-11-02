using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SlideController : MonoBehaviour
{
    [SerializeField] private RectTransform _SlidebarImage = null; //RectTransformとしてImageを宣言
    public void HomeSlide()
    {
        //RectTransform rt = _SridebarImage.GetComponent<RectTransform>(); →RectTransformをゲット済
        Vector3 start = _SlidebarImage.localPosition;
        _SlidebarImage.localPosition = start;

            if(start.x == -187) //watch
            {
               start.x -= 125;
            }else if(start.x == -61){ //MyPage
                start.x -= 251;
            }else if(start.x == 63){ //Group
                start.x -= 375;
            }else if(start.x == 188){ //Information
                start.x -= 500;
            }else if(start.x == 313){ //Menu
                start.x -= 625;
            }
        Vector3 end = _SlidebarImage.localPosition;
        _SlidebarImage.DOLocalMove(start, 0.5f);   
    }

    public void WatchSlide()
    {
        
            Vector3 start = _SlidebarImage.localPosition;
            _SlidebarImage.localPosition = start;
            
            if(start.x == -312)//HomeButton
            {
                start.x += 125;
            }else if(start.x == -61){ //MyPage
                start.x -= 126;
            }else if(start.x == 63){ //Group
                start.x -= 250;
            }else if(start.x == 188){ //Information
                start.x -= 375;
            }else if(start.x == 313){ //Menu
                start.x -= 500;
            }
            
            
            Vector3 end = _SlidebarImage.localPosition;
            _SlidebarImage.DOLocalMove(start, 0.5f);        
    }

    public void MypageSlide()
    {
            Vector3 start = _SlidebarImage.localPosition;
            _SlidebarImage.localPosition = start;
            
            if(start.x == -312)//HomeButton
            {
                start.x += 251;
            }else if(start.x == -187){ //Watch
                start.x += 126;
            }else if(start.x == 63){ //Group
                start.x -= 124;
            }else if(start.x == 188){ //Information
                start.x -= 249;
            }else if(start.x == 313){ //Menu
                start.x -= 374;
            }
           
             Vector3 end = _SlidebarImage.localPosition;
            _SlidebarImage.DOLocalMove(start, 0.5f);
    }

    public void GroupSlide()
    {
            Vector3 start = _SlidebarImage.localPosition;
            _SlidebarImage.localPosition = start;
            //start.x += 375;
            if(start.x == -312)//HomeButton
            {
                start.x += 375;
            }else if(start.x == -187){ //Watch
                start.x += 250;
            }else if(start.x == -61){ //MyPage
                start.x += 124;
            }else if(start.x == 188){ //Information
                start.x -= 125;
            }else if(start.x == 313){ //Menu
                start.x -= 250;
            }
            
            Vector3 end = _SlidebarImage.localPosition;
            _SlidebarImage.DOLocalMove(start, 0.5f); 
        
    }

    public void InformationSlide()
    {
            Vector3 start = _SlidebarImage.localPosition;
            _SlidebarImage.localPosition = start;
            
            if(start.x == -312)//HomeButton
            {
                start.x += 500;
            }else if(start.x == -187){ //Watch
                start.x += 375;
            }else if(start.x == -61){ //MyPage
                start.x += 249;
            }else if(start.x == 63){ //Group
                start.x += 125;
            }else if(start.x == 313){ //Menu
                start.x -= 125;
            }
           
            Vector3 end = _SlidebarImage.localPosition;
            _SlidebarImage.DOLocalMove(start, 0.5f);
    }

    public void MenuSlide()
    {
            Vector3 start = _SlidebarImage.localPosition;
            _SlidebarImage.localPosition = start;
            
             if(start.x == -312)//HomeButton
            {
                start.x += 625;
            }else if(start.x == -187){ //Watch
                start.x += 500;
            }else if(start.x == -61){ //MyPage
                start.x += 374;
            }else if(start.x == 63){ //Group
                start.x += 250;
            }else if(start.x == 188){ //Information
                start.x += 125;
            }
            
            Vector3 end = _SlidebarImage.localPosition;
            _SlidebarImage.DOLocalMove(start, 0.5f);
    }
}
