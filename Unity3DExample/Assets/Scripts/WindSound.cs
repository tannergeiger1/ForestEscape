using UnityEngine;
using System.Collections;

public class WindSound : MonoBehaviour {


	private AudioSource source;		// Reference to the animator component.
	public AudioClip WSound;
	public float vol = 0.5f;

	void Awake(){
		source = GetComponent<AudioSource>();

	}

	void OnTriggerEnter (Collider other){

		source.PlayOneShot(WSound,vol);
	}

	void OnTriggerExit (Collider other){

	}
}
