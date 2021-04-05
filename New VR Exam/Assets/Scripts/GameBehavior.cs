using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scoring system and text labels on the game screen
public class GameBehavior : MonoBehaviour

{
    private string labelText = "Follow the pearls and find the fish, turtle, and burger in order!";
    private bool showWinScreen = false;
    private int itemsPicked = 0;

    public int Items
    {

        get { return itemsPicked; }

        set
        {
            itemsPicked = value;

            if (itemsPicked == 40)

            {
                labelText = "             You've found all characters!";

                showWinScreen = true;

            }
            else
            {
                labelText = "                      Keep searching!";

            }
        }
    }

    void OnGUI()
    {

        GUI.Box(new Rect(20, 50, 150, 25), "Score: " + itemsPicked);

        GUI.Label(new Rect(Screen.width / 2 - 130, Screen.height - 50, 300, 50), labelText);


        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON :)"));
            {

            }
        }



    }

}
