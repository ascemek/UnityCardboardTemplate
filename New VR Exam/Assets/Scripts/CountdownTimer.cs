using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float startingTime = 15f;
    [SerializeField] float currentTime = 0f;
    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("        0");
     
        if(currentTime <= 0 )
        {
            currentTime = 0;
        }

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            countdownText.text = ("Out of time!");

            /*
            void OnGUI()
            {
                GUI.Box(new Rect(20, 50, 150, 25), "Out of time!!");
                Debug.Log("Out of time!!");
              
            }
            */

        }
    }
    
}
