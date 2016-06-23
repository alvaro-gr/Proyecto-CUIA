using UnityEngine;
using System.Collections;

public class EstadoJuego : MonoBehaviour {
	
	public CanvasRenderer uiVidas;
	public UnityEngine.UI.Text uiPuntuacion;
	public Texture[] vidasImagenes; //Vector para guardar las imagenes de las vidas.
	public int vidasActuales = 3;
	public int vidasIniciales = 3;//Inicialmente el jugador tiene 3 vidas

	public int puntuacion = 0; //Para llevar la cuenta de los puntos

	internal bool gameOver = false;//Nos dice si el juego ha llegado al gameover o no

	// Use this for initialization
	void Start () {
		
		uiVidas.SetTexture (vidasImagenes[vidasActuales]);//Inicialmente se deben de vostar vidasImagenes[3] que guarda la imagen con 3 vidas

		puntuacion = 0;
		actualizarPuntuacion ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Restar una vida.
	public void perderUnaVida(){
		if(vidasActuales > 0){
			vidasActuales--;
		}
		//Si se pierde una vida, se cambia la imagen a una imagen con una vida menos.
		if (vidasActuales < vidasImagenes.Length) {
			uiVidas.SetTexture (vidasImagenes [vidasActuales]);
		}

		if (vidasActuales <= 0) {
			SendMessage ("partidaTerminada", SendMessageOptions.DontRequireReceiver); //Mensaje a la funcion "partidaTerminada"
		}	
	}

	//Incrementa la puntuación segun n
	public void incrementarPuntuacion(int n){
		puntuacion += n;
		actualizarPuntuacion();
	}	

	//Mostrar puntuacion para pruebas
	public void actualizarPuntuacion(){
		uiPuntuacion.text = puntuacion.ToString ("D5");
	}



}
