using UnityEngine;
using System.Collections;

public class GeneradorAtomBall : MonoBehaviour {

	public Transform atomballPrefab;
	public Transform puntoRotacionObjeto; //Referencia al objeto desde que rota la Atomball
	public Transform padreAtomball; //Padre de la Atomball

	public float primeraBola = 2.5f; //Tiempo en salir la primera Atomball
	public float tiempoEntreBola = 1.7f; //Tiempo que se tarda en generar otra Atomball

	private float horaSiguienteBola; //Guarda la hora en la que se va a generar la siguiente Atomball

	public float tiempoCumplido = 120f;
	public float velocidadRotacionTiempoCumplido = 300f;
	public float incrementoRadioTiempoCumplido = 0.2f;
	public float velocidadRotacionInicial = 100f;
	public float incrementoRadioInicial = 0.1f;

	private float diferenciaVelocidadRotacion, diferenciaIncrementoRadio;

	// Use this for initialization
	void Start () {
		horaSiguienteBola = Time.time + primeraBola; // Guarda la hora en que las Atomball se van generando

		diferenciaVelocidadRotacion = velocidadRotacionTiempoCumplido - velocidadRotacionInicial;
		diferenciaIncrementoRadio = incrementoRadioTiempoCumplido - incrementoRadioInicial;
	}
	
	// Update is called once per frame
	void Update () {
		float valorVelocidadRotacion;
		float valorIncrementoRadio;

		if (Time.time >= horaSiguienteBola) { //Ya es la hora de generar otra Atomball? pues establecemos la siguiente hora para lanzar el fantasma
			horaSiguienteBola = Time.time + tiempoEntreBola;
			Transform atomballTransform = Instantiate(atomballPrefab, atomballPrefab.transform.position, puntoRotacionObjeto.transform.rotation) as Transform; //Generamos el objeto "Atomball"
			atomballTransform.parent = padreAtomball; //Establecemos el padre de Atomball
			Rotar rotar = atomballTransform.GetComponent<Rotar>();//Referencia la componente Rotar 
			rotar.objeto_centro_rotacion = puntoRotacionObjeto; //Establecemos el objeto des de donde rotar 

			valorVelocidadRotacion = ((diferenciaVelocidadRotacion * Time.timeSinceLevelLoad) / tiempoCumplido) + velocidadRotacionInicial;
			valorIncrementoRadio = ((diferenciaIncrementoRadio * Time.timeSinceLevelLoad) / tiempoCumplido) + incrementoRadioInicial;
			rotar.rotacion_segundos = valorVelocidadRotacion;
			rotar.incrementar_radio_segundo = valorIncrementoRadio;
		}
	}
}
