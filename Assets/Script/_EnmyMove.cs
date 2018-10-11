using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _EnmyMove : MonoBehaviour {
    private float speed;
    
    public GameObject baozha;
    public GameObject paodan;
    private float cd = 1f;
    private float currTime;
    private float currTime_cd;
    EnmyManager enmyManager;
    [Range(1,7)]
    public int number;

    private int Number;
    
    // Use this for initialization
    void Start () {
        speed = Random.Range(2f, 6f);
        currTime = Time.time;
        currTime_cd = Time.time;
        enmyManager = GameObject.Find("EnemyManager").GetComponent<EnmyManager>();
        if (number == 1)
        {
            Number =1;
        }
        if (number == 2)
        {
            Number = 2;
        }
        if (number == 3)
        {
            Number = 3;
        }
        if (number == 4)
        {
            Number = 4;
        }
        if (number == 5)
        {
            Number = 5;
        }
        if (number == 6)
        {
            Number = 3;
        }
        if (number == 7)
        {
            Number = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(0, Time.deltaTime * speed, 0);
        
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
        if(transform.position.x>4||transform.position.x<-4) Destroy(gameObject);
        currTime = Time.time;
        if((currTime - currTime_cd) > cd)
        {
            paodan.transform.position = transform.position;
            Instantiate(paodan);
            currTime_cd = currTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "PaoDan"|| collision.transform.tag == "Player")
        {
            Number--;
            if (Number <= 0)
            {
                Destroy(gameObject);
                Instantiate(baozha, transform.position, Quaternion.identity);
                EnmyManager.grade += 100;
                enmyManager.text.text = EnmyManager.grade + "";
            }
        }
    }

   

}
