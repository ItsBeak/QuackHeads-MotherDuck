using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	public AudioClip getDuck;
	public AudioClip loseDuck;
	public AudioClip musicAudio;
	public AudioClip ambienceAudio;

	public AudioSource getDuckAudioSource;
	public AudioSource loseDuckAudioSource;
	public AudioSource musicAudioSource;
	public AudioSource ambienceAudioSource;



	public void PickUpDuck(){
		if (getDuckAudioSource.clip != null) {
			getDuckAudioSource.Play ();
		}
	}

	public void LoseDuck(){
		if (loseDuckAudioSource.clip != null) {
			loseDuckAudioSource.Play ();
		}
	}

	// Update is called once per frame
	void Start () {
	
		if (musicAudioSource) {
			musicAudioSource.clip = musicAudio;
			musicAudioSource.Play ();
		}

		if (ambienceAudioSource)
		{
			ambienceAudioSource.clip = ambienceAudio;
			ambienceAudioSource.Play();
		}

		if (getDuck) {
			getDuckAudioSource.clip = getDuck;
		}

		if (loseDuck) {
			loseDuckAudioSource.clip = loseDuck;
		}
	}
}
