using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40.0f;

    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        
    }
}
