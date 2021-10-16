using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Draggable : MonoBehaviour
{
    private Transform selfTransform;
    private Rigidbody selfRigidbody;

    public float dragSpeedMultiplier = 1.7f;

    private void Start() {
        selfTransform = GetComponent<Transform>();
        selfRigidbody = GetComponent<Rigidbody>();
    }

    private void OnMouseDown() {
        Debug.Log("Clicked");
    }

    private void OnMouseDrag() {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 objectPos = selfTransform.position;

        Vector3 offset = cursorPos - objectPos;

        Vector3 newVelocity = new Vector3(offset.x, offset.y, 0);

        newVelocity *= dragSpeedMultiplier;

        selfRigidbody.velocity = newVelocity;
        
    }
}
