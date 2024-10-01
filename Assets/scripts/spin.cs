using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    
}