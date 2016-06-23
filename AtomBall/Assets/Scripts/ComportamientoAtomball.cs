using UnityEngine;
using System.Collections;

public class ComportamientoAtomball : MonoBehaviour {

	public Transform explosionPrefab;
	private EstadoJuego estadoJuego;

	// Use this for initialization
	void Start () {
		estadoJuego = ControladorDelJuego.obtenerComponente<EstadoJuego> ("ControladorJuego");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Destruye la "AtomBall", destruye el objeto bola.
	void Muere(){
		Rotar rotar = GetComponent<Rotar> ();
		AtomballSeEscapa atomballSeEscapa = GetComponent<AtomballSeEscapa> ();
		//Si el radio_actual es igual al maximoRadio, quiere decir que se le ha dado a la bola justo antes
		//de escapar, entonces esa bola vale 100 puntos. Si el radio_actual es la mitad del maximoRadio entonces
		//la puntuacion valdra 25 por bola.
		int puntuacion = (int)((100 * rotar.radio_actual) / atomballSeEscapa.maximoRadio); 
		estadoJuego.incrementarPuntuacion(puntuacion);//Incrementar la puntuacion por cada bola eliminada
		//Generar la explosion
		Instantiate (explosionPrefab, transform.position, transform.rotation);
		//Destruir el objeto que contega el metodo "Muere"
		Destroy (gameObject.transform.gameObject);

	}	
}
