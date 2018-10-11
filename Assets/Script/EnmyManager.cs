using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnmyManager : MonoBehaviour {
    public GameObject[] Enmy;
    private Quaternion quaternion;
    public Text text;
    public  static float grade;
    // Use this for initialization
    void Start () {
        quaternion = Quaternion.Euler(0, 0, Random.Range(160f, 200f));
        InvokeRepeating("ProcudeEnemy", 2, 2);
        grade = 0;
    }
	
	// Update is called once per frame
	void Update () {
        quaternion = Quaternion.Euler(0, 0, Random.Range(160f, 200f));

    }
    void ProcudeEnemy()
    {
        int x = Random.Range(0, Enmy.Length);
        Instantiate(Enmy[x], new Vector3(Random.Range(-2.3f, 2.3f), 5.5f, 0), quaternion);

    }
}
