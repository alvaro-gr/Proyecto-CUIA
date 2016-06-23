using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {

	public Transform objeto_centro_rotacion;
	public float rotacion_segundos = 100f; //Grados en segundos que queremos que rote

	//alejar la bola del centro poco a poco
	public float radio_actual = 0.5f;
	public float incrementar_radio_segundo = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Rotacion de la bola 
		radio_actual += incrementar_radio_segundo * Time.deltaTime;

		transform.position = new Vector3 (objeto_centro_rotacion.position.x, transform.position.y, objeto_centro_rotacion.position.z);

		transform.Translate (-radio_actual, 0, 0);

		transform.RotateAround (objeto_centro_rotacion.position, Vector3.up, rotacion_segundos * Time.deltaTime);
	}
}
