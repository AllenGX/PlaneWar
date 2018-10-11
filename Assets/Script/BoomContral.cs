using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomContral : MonoBehaviour {

    //// Use this for initialization
    void Start()
    {
        InvokeRepeating("DeletBoom", 0.8f, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DeletBoom()
    {
        Destroy(gameObject);
    }
}
