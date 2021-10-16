using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject targetCamera;
    public Vector3 targetPosition;
    
    private Transform cameraTransform;
    
    private void Start() {
        cameraTransform = targetCamera.GetComponent<Transform>();
    }

    private void OnMouseDown() {
        cameraTransform.position = targetPosition;
    }
}
