using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botonAtras : MonoBehaviour {

	public enum Acciones{ Salir, CargarEscena }
	public Acciones accion;
	public int escena;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {//si de pulsa la tecla de atras contemplanmos dos acciones
		if (Input.GetKeyDown(KeyCode.Escape)){
			switch (accion) {
			case Acciones.Salir:
				Application.Quit();
				break;
			case Acciones.CargarEscena:
				SceneManager.LoadScene (escena);
				break;
			}
		}
	}
}
