using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneTracker : MonoBehaviour
{
    public List<GameObject> bones;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Bone") {
            bones.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Bone") {
            bones.Remove(other.gameObject);
        }
    }
}
