using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BgGround : MonoBehaviour {
    private float speed = 2;

    // Use this for initialization
    void Start () {
      
       
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(transform.position.x);
        if (transform.position.y > -10)
        {
            transform.position = new Vector3(0, transform.position.y - Time.deltaTime * speed,0);
        }
        else
        {
            transform.position = new Vector3(0,10, 0);
        }
       
    }
}
