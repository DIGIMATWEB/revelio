using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class nativesharing : MonoBehaviour {
	public Button thisbtn;
    //libreria de  deimplementacion  de contenido compartido por medio de servicion post mime
	void Update()
	{
		/*if( Input.GetMouseButtonDown( 0 ) )        //de momento se comentan estas dos clases ya que se procede a utilizar el metodo task on click para dejar el espacio vacio y poder utilizar mas botones en el canvas
			StartCoroutine( TakeSSAndShare() );*/
	}

	void Start(){
		Button btn = thisbtn.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	public void TaskOnClick(){
		Debug.Log ("boton presionado");	
        //GetComponent<AudioSource>().Play();
		StartCoroutine( TakeSSAndShare() );

		//buttnsUI ();
		//GetComponent<AudioSource> ().Play ();
		//thisbtn.gameObject.SetActive (true);
	}

	/*private void buttnsUI ()
	{
		thisbtn.gameObject.SetActive (false);
		GetComponent<AudioSource> ().Play ();
	}*/

	private IEnumerator TakeSSAndShare()
	{
		yield return new WaitForEndOfFrame();
		

		Texture2D ss = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
		ss.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
		ss.Apply();

		string filePath = Path.Combine( Application.temporaryCachePath, "shared img.png" );
		File.WriteAllBytes( filePath, ss.EncodeToPNG() );

		// To avoid memory leaks
		Destroy( ss );

		new NativeShare().AddFile( filePath ).SetSubject( "my tatoo en: " ).SetText( "#floresnegras" ).Share();

		// Share on WhatsApp only, if installed (Android only)
		//if( NativeShare.TargetExists( "com.whatsapp" ) )
		//	new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();
	}
}
