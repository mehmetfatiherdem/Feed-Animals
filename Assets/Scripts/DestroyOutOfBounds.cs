using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const float topBound = 30;
    private const float lowerpBound = -10;
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerpBound)
        {
            Destroy(gameObject);
        } 
    }
}
