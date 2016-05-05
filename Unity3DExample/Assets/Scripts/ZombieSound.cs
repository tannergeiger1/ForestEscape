using UnityEngine;
using System.Collections;

public class ZombieSound : MonoBehaviour {


	private AudioSource source;		// Reference to the animator component.
	public AudioClip ZSound;
	public float vol = 0.25f;

	void Awake(){
		source = GetComponent<AudioSource>();

	}

	void OnTriggerEnter (Collider other){

		source.PlayOneShot(ZSound,vol);
	}

	void OnTriggerExit (Collider other){

	}
}
