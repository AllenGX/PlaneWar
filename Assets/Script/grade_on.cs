using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grade_on : MonoBehaviour {
    public Text text;
    private EnmyManager manager;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(EnmyManager.grade);
        text.text = ""+EnmyManager.grade;
	}
}
