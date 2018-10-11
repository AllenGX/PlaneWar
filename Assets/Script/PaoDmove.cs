using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaoDmove : MonoBehaviour {

    private float speed = 7;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speed, 0);
        if (transform.position.y <- 5f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
