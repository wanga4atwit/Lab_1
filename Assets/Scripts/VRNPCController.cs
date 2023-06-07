using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRNPCController : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
