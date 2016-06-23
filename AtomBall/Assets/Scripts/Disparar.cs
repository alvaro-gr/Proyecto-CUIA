using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

	public Transform disparo_prefab; //Para guardar el objeto a disparar.
	public float tiempoEntreDisparos = 0.5f; //Tiempo para poder disparar entre un disparo y otro.
	private float siguienteDisparo = 0f; //Para llevar contado el timepo entre un disparo y otro.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0) && (Time.time > siguienteDisparo)) {//Si se toca la pantalla entonces se dispara
			siguienteDisparo = Time.time + tiempoEntreDisparos;
			Instantiate (disparo_prefab, transform.position, transform.rotation);
		}
	}
}