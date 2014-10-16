using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	public AudioSource[] sources;
	public int currentSource = 0;
	public float fadeTime = 1;
	private bool isSwitching = false;

	// Use this for initialization
	void Start () {
		if (fadeTime <= 0) {
			fadeTime = 1;
		}

		sources[0].Play();
		sources[1].Play();
		sources[1].Pause();
		sources[1].volume = 0;
	}

	public void Switch() {
		if (currentSource == 0) 
		{ 
			currentSource = 1; 
		} else { 
			currentSource = 0;
		}
		isSwitching = true;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (!isSwitching) {
			return;
		}
		int maxVolume = 100;
		if (sources[currentSource].volume < maxVolume / 100.0f) {
			if (!sources[currentSource].isPlaying) {
				sources[currentSource].Play();
			}
			float deltaVolume = maxVolume * (Time.deltaTime / fadeTime) / 100; // devide 100, transform to actual volume value.
			sources[currentSource].volume += deltaVolume;
			for (int i = 0; i < sources.Length; i++) {
				if (i == currentSource) {
					continue;
				}
				
				sources[i].volume -= deltaVolume;
			}
		} else {
			for (int i = 0; i < sources.Length; i++) {
				if (i == currentSource) {
					continue;
				}
				sources[i].Pause();
				sources[i].volume = 0;
			}
			isSwitching = false;
		}
	
	}
}
