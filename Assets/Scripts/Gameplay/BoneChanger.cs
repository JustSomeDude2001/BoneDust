using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneChanger : MonoBehaviour
{
    
    private BoneTracker selfBoneTracker;
    private void Start() {
        selfBoneTracker = GetComponent<BoneTracker>();
    }

    public float decayRate = 0;
    public float soulShift = 0;
    public float humidityChange = 0;
    public float sponginessChange = 0;
    public float massChange = 0;

    virtual protected void advance(PlayEntity currentBone) {
        
        if (currentBone.decay + decayRate <= 0) {
            return;
        }

        if (currentBone.soul + soulShift <= 0) {
            return;
        }

        if (currentBone.humidity + humidityChange <= 0) {
            return;
        }

        if (currentBone.sponginess + sponginessChange <= 0) {
            return;
        }
        
        if (currentBone.mass + massChange <= 0) {
            return;
        }

        currentBone.decay      += decayRate;
        currentBone.soul       += soulShift;
        currentBone.humidity   += humidityChange;
        currentBone.sponginess += sponginessChange;
        currentBone.mass       += massChange; 
    }

    private void FixedUpdate() {
        for(int i = 0; i < selfBoneTracker.bones.Count; i++) {
            PlayEntity currentBone = selfBoneTracker.bones[i].GetComponent<PlayEntity>();
            advance(currentBone);
        }
    }
}
