using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public GameObject go;
    public int level;
  
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "target")
        {
            go.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Application.LoadLevel(level);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "target")
        {
            go.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Application.LoadLevel(level+1);
        }
    }

    /*private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 36;
        if (GUI.Button(new Rect(50,30, 200,80 ), "返回菜单",style)){
            Application.LoadLevel(0);
        }    
      
    }*/
}
