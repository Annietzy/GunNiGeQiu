using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 选择关卡
/// </summary>
public class Select : MonoBehaviour {

    public void BackMenu()
    {
        Application.LoadLevel(0);
    }

    public void Select1()
    {
       
        Application.LoadLevel(1);

    }

    public void Select2()
    {
        Time.timeScale = 1;
        Application.LoadLevel(2);

    }
    public void Select3()
    {
        Time.timeScale = 1;
        Application.LoadLevel(3);

    }
    public void Select4()
    {
        Time.timeScale = 1;
        Application.LoadLevel(4);

    }
    public void Select5()
    {
        Time.timeScale = 1;
        Application.LoadLevel(5);

    }
    public void Select6()
    {
        Time.timeScale = 1;
        Application.LoadLevel(6);

    }
    public void Select7()
    {
        Time.timeScale = 1;
        Application.LoadLevel(7);

    }
    public void Select8()
    {
        Time.timeScale = 1;
        Application.LoadLevel(8);

    }
    public void Select9()
    {
        Time.timeScale = 1;
        Application.LoadLevel(9);

    }
    public void Select10()
    {
        Time.timeScale = 1;
        Application.LoadLevel(10);

    }


}