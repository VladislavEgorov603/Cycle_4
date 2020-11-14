using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    Transform PlayerTransform;
    public Vector3 Ch;

    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Camera.main.transform.position = PlayerTransform.position + Ch;
    }
}
