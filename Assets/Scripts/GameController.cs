using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
{
    public static int playerscore = 0;
    public static int npcscore = 0;
    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Player Score: " + playerscore, scoreStyle);
        GUI.Label(new Rect(10, 35, 200, 50), "NPC Score: " + npcscore, scoreStyle);
    }
}
