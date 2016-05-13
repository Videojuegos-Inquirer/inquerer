using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CambiarVentana : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CambiarPantalla(string nuevaVentana) {
        SceneManager.LoadScene(nuevaVentana);
    }
}
