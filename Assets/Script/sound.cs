using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class sound : MonoBehaviour {
	
		public AudioClip impact;
		AudioSource audioSource;

		void Start()
		{
			audioSource = GetComponent<AudioSource>();
		}

		void OnTriggerEnter()
		{
			audioSource.PlayOneShot(impact, 0.7F);

		}


	}
