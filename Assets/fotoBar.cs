using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fotoBar : MonoBehaviour {

	public GameObject im1;

	public Texture ImageIdle;
	// Use this for initialization

	void Start () {
		
		im1.GetComponent<RawImage>().texture=ImageIdle;
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<RawImage> ();
	}
}
