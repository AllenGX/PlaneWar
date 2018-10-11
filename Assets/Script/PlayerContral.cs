using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContral : MonoBehaviour {
    public GameObject baozha;
    public GameObject player;
    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "EnemyPaoDan"|| collision.transform.tag == "Enemy")
        {
            Destroy(player);
            Instantiate(baozha, transform.position, Quaternion.identity);
            SceneManager.LoadScene(2);
        }


    }
}
