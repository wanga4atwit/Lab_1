using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class VRCubeController : OVRGrabbable
{
    private GameController scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Override the base GrabBegin function
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        gameController.OnCubeGrabbed();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Add to score when the player hits a cube
            GameController.playerscore++;
            // Destroy the cube
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "npc")
        {
            GameController.npcscore--;
            Destroy(gameObject);
        }
    }
}
