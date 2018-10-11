using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LodingGame : MonoBehaviour {

	public void LoadGame()
    {
        SceneManager.LoadScene("Planestart");
    }
}
