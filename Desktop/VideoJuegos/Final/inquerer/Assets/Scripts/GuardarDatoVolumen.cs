using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuardarDatoVolumen : MonoBehaviour
{
    public Slider sliderVolumen;

    void Update(){
        Debug.Log("asad" + sliderVolumen.value);
    }

}
