using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUi : MonoBehaviour {

    public int winLevel;   //当前关卡
    //重玩
    public void Reaply()
    {
        Time.timeScale = 1;
        Application.LoadLevel(winLevel);
       
    }
    //下一关
    public void Next()
    {
        Time.timeScale = 1;
        Application.LoadLevel(winLevel+1);

    }

    //选择关卡界面
    public void Select()
    {
        Application.LoadLevel("Scene/StartUI/SelectUI");
    }
    //返回主菜单页面
    public void BackMenu()
    {
        Application.LoadLevel(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
