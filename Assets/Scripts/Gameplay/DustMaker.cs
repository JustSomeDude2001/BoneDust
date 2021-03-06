using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustMaker : MonoBehaviour
{
    private BoneTracker selfBoneTracker;
    private Transform selfTransform;

    public GameObject prefab;

    private void Start() {
        selfBoneTracker = GetComponent<BoneTracker>();
        selfTransform = GetComponent<Transform>();
    }

    public void grindBones() {
        if(selfBoneTracker.bones.Count == 0) {
            return;
        }

        float totalMass = 0;
        
        float avDecay = 0;
        float avSoul = 0;
        float avHumidity = 0;
        float avSponginess = 0;
    
        for (int i = 0; i < selfBoneTracker.bones.Count; i++) {
            PlayEntity currentBone = selfBoneTracker.bones[i].GetComponent<PlayEntity>();
            
            totalMass += currentBone.mass;

            avDecay += currentBone.decay * currentBone.mass;
            avSoul += currentBone.soul * currentBone.mass;
            avHumidity += currentBone.humidity * currentBone.mass;
            avSponginess += currentBone.sponginess * currentBone.mass;
        }

        avDecay /= totalMass;
        avSoul /= totalMass;
        avHumidity /= totalMass;
        avSponginess /= totalMass;
    
        for (int i = 0; i < selfBoneTracker.bones.Count; i++) {
            Destroy(selfBoneTracker.bones[i]);
        }

        selfBoneTracker.bones.Clear();

        float toxicity = avDecay * 2;
        float magic = avSoul * 2;
        float tenderness = avHumidity + avSponginess;

        GameObject newDust = Instantiate(prefab, selfTransform.position, new Quaternion());

        Dust statDust = newDust.GetComponent<Dust>();
        
        statDust.toxicity = toxicity;
        statDust.magic = magic;
        statDust.tenderness = tenderness;
        statDust.mass = totalMass;
    }
}
