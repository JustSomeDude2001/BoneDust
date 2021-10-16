using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humidifier : MonoBehaviour
{
    private BoneTracker selfBoneTracker;

    public float decayRate = 0;
    public float soulShift = 0;
    public float humidityChange = 0;
    public float sponginessChange = 0;
    public float massChange = 0;

    private void Start() {
        selfBoneTracker = GetComponent<BoneTracker>();
    }
}
