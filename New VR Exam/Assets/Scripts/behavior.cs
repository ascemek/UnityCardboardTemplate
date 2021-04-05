using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class behavior : MonoBehaviour
{
    private bool showWinScreen = false;

    //gameObject.GetComponent<behavior>().currentTime = 0;
    
    void OnGUI()
    {

        if (showWinScreen = true)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON :)")) ;
            {
            }
        }
    }

}
