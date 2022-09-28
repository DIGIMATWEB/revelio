using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fotoDeSala : MonoBehaviour {

	//private GameObject gObj;
	public RawImage takefoto;  // esta imagen pertenece al boton
	private static Texture texturaBoton; // esta textura sera la nueva textura para cambiar

	public GameObject FotoSala;        //variable publica para cambiar foto en la columna
	public Text textSala;             // variable para cambiar TEXTO
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//OnClickScrollphoto ();
		takefoto.texture = gameObject.GetComponent<RawImage> ().texture;//takefoto.texture = (Texture)texturaBoton;
	}

	public void OnClickScrollphoto()
	{
		//FotoSala.GetComponent<RawImage>().texture=(Texture)texturaBoton;
		FotoSala.GetComponent<RawImage>().texture=takefoto.texture;
	}
}
