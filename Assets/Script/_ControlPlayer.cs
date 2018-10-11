using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ControlPlayer : MonoBehaviour {
    private float speed = 5;
    private Rigidbody2D rb;
    public GameObject paodan;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + new Vector3(h, v,0) * speed * Time.deltaTime);
        if (Input.GetButtonDown("j"))
        {
            paodan.transform.position = transform.position;
            Instantiate(paodan);
            
        }
    }
}
