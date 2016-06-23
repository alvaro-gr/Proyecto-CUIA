using UnityEngine;
using System.Collections;

public class Destruir : MonoBehaviour {

	public float tiempoDeVida = 2f; //Tiempo de vida de un disparo

	// Use this for initialization
	void Start () {
		Destroy (gameObject, tiempoDeVida);

	}

	// Update is called once per frame
	void Update () {

	}
}
