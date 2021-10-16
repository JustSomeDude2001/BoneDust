using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnpoint;

    private void OnMouseDown() {
        GameObject newObject = Instantiate(prefab);
        newObject.GetComponent<Transform>().position = spawnpoint;
    }
}
