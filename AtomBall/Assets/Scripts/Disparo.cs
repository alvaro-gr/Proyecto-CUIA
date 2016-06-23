using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(transform.forward * 1000);//Fuerza del disparo
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Funcion para detectar cuando el disparo colisiona con algo
	void OnTriggerEnter(Collider other){
		//Se utiliza "tag" por que para hacer referencia a varios objetos. "name" para referinos a solo uno.
		if (other.tag == "Enemigo") {//Si el objeto con el colisionamos es el "enemigo" una bola entonces los eliminamos.
			Destroy (gameObject);
			other.SendMessage ("Muere", SendMessageOptions.DontRequireReceiver);//Mensaje a los objetos que tenga el metodo "Muere"
		}	
	}
}
