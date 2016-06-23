using UnityEngine;
using System.Collections;

public class EventosMarcador : MonoBehaviour {


	public GameObject notificacion;
	private EstadoJuego estadoJuego; 


	// Use this for initialization
	void Start () {
		estadoJuego = GetComponent<EstadoJuego> ();//Referencia al componente estadoJuego

	}
	
	// Update is called once per frame
	void Update () {
		//Para hacer pruebas desde el pc.
		if (Input.GetKeyDown (KeyCode.Q)) {
			marcadorPerdido();
		} else if (Input.GetKeyDown (KeyCode.W)) {
			marcadorEncontrado();
		}
	
	}

	//Se ejecutara cuando se encuntre el marcador
	public void marcadorEncontrado(){
		if (estadoJuego.gameOver)//Si gameOver vale "true" se para todo.
			return;

		notificacion.SetActive(false);//Desactiva el "canvas" y no se muestra el texto

		Time.timeScale = 1f;//Hace que "deltaTime" valga lo mismo por que lo lo esacla por 1"
	}

	//Se ejecutara cuando se pierda el marcador de vista
	public void marcadorPerdido(){
		if (estadoJuego.gameOver)//Si gameOver vale "true" se para todo.
			return;

		notificacion.SetActive(true);//Activa el "canvas" y se muestra el texto

		Time.timeScale = 0f;//Hace que "deltaTime" valga 0, por tanto se detiene todos los elementos que dependan del tiempo	
	}
}
