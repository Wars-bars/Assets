using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;

    Rigidbody2D rb;
    Transform tr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<>(Transform);
    }

    
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            tr.position += new Vector3(1, 0, 0);
        }
    }
}
