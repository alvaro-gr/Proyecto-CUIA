using UnityEngine;
using System.Collections;

public class AtomballSeEscapa : MonoBehaviour {

	public float maximoRadio = 3f;//Indica el radio que toma una atomball para perder una vida
	private Rotar rotar; //Referencia a la clase Rotar
	private EstadoJuego estadoJuego;//Referencia a la calse EstadoJuego

	// Use this for initialization
	void Start () {
		rotar = GetComponent<Rotar> ();//Obtener una referencia al script Rotar
		estadoJuego = ControladorDelJuego.obtenerComponente<EstadoJuego>("ControladorJuego");//Obtener una referencia a la clase EstadoJuego
	
	}
	
	// Update is called once per frame
	void Update () {
		if (rotar.radio_actual >= maximoRadio) {
			atomballSeEscapo ();
		}	
			
	}

	//Destruye la atomball cuando esta supera el maximoRadio
	private void atomballSeEscapo(){
		Destroy (gameObject);//Se elimina el objeto donde esta colocado este script
		estadoJuego.perderUnaVida();//Restamos una vida
	}	
}
