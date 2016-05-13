using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform Target;
    public Transform Arrow;

    void LateUpdate() {
        transform.position = new Vector3(Target.position.x, (Target.position.y)+2, Target.position.z);
        transform.position = new Vector3(Target.position.x, (Target.position.y) + 2, Target.position.z);
    }
}
