using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	private EstadoJuego estadoJuego; 
	public GameObject gameoverText;
	public GameObject puntuacionText;
	public UnityEngine.UI.Text totalPuntos;
	public float tiempoEsperaGameOver = 15f;
	private float tiempoParaVolverMenu;

	// Use this for initialization
	void Start () {

		estadoJuego = GetComponent<EstadoJuego> ();//Referencia al componente estadoJuego
	
	}
	
	// Update is called once per frame
	void Update () {
		if (estadoJuego.gameOver && (Time.realtimeSinceStartup > tiempoParaVolverMenu)) {
			SceneManager.LoadScene (0); //Cargar la escena numero 0 "la portada"
		}
	}

	//Acciones para cuando llegue el "GameOver"
	public void partidaTerminada(){
		tiempoParaVolverMenu = Time.realtimeSinceStartup + tiempoEsperaGameOver;
		estadoJuego.gameOver = true;
		Time.timeScale = 0f;
		gameoverText.SetActive (true);
		puntuacionText.SetActive (false);
		totalPuntos.text = "Puntuación: " + estadoJuego.puntuacion.ToString ("D5");
	}
}
