using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TocarParaEmpezar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {//Cargar la escena 1 "la del juego"
		
		if (Input.touchCount >= 1) {
			SceneManager.LoadScene (1);
		}	
	}
}
