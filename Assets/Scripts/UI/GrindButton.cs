using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindButton : MonoBehaviour
{
    public GameObject grinder;
    private DustMaker dustMaker;

    private void Start() {
        dustMaker = grinder.GetComponent<DustMaker>();
    }

    private void OnMouseDown() {
        dustMaker.grindBones();
    }
}
