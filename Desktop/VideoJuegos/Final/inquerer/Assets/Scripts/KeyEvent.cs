using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KeyEvent : MonoBehaviour {

    public string nuevaVentana;

	void Update () {
        if (Input.GetKey("escape")) {
            SceneManager.LoadScene(nuevaVentana);
        }
	}
}
