using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_animation : MonoBehaviour {


	[SerializeField] private int fps = 30;                  // The number of times per second the image should change.
	[SerializeField] private MeshRenderer canvasplane;             // The mesh renderer who's texture will be changed.
	 public Texture[] texturas;              // The textures that will be looped through.


	private WaitForSeconds esperaunsegundo;                         // The delay between frames.
	private int texturaActual;                              // The index of the textures array.
	private bool empieza;                                         // Whether the textures are currently being looped through.

	// Use this for initialization
	void Start () {
		empieza = true;
		StartCoroutine (PlayTextures ());
	}

	// Update is called once per frame
	void Update () {
		
	}

	private void Awake ()
	{
		// The delay between frames is the number of seconds (one) divided by the number of frames that should play during those seconds (frame rate).
		esperaunsegundo = new WaitForSeconds (1f / fps);
	}



	private IEnumerator PlayTextures ()
	{
		// So long as the textures should be playing...
		while (empieza)
		{
			// Set the texture of the mesh renderer to the texture indicated by the index of the textures array.
			canvasplane.material.mainTexture = texturas[texturaActual];

			// Then increment the texture index (looping once it reaches the length of the textures array.
			texturaActual= (texturaActual + 1) % texturas.Length;

			// Wait for the next frame.
			yield return esperaunsegundo;
		//	Debug.Log ("empieza a correr");
		}
	}
}

