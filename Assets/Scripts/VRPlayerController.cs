using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRPlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        Vector3 move = new Vector3(input.x, 0, input.y);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
