using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    private void Start()
    {
        Character char1 = new("High", "Close");
        char1.MakeDecision();

        Character char2 = new("Low", "Close");
        char2.MakeDecision();

        Character char3 = new("High", "Far");
        char3.MakeDecision();

        Character char4 = new("Low", "Far");
        char4.MakeDecision();
    }
}
