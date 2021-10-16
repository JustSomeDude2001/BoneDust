using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneAnalyzer : MonoBehaviour
{
    public string idleText = "Bone Analyzer";
    public GameObject display;
    private TextMesh textMesh;

    private BoneTracker selfBoneTracker;

    private void Start() {
        textMesh = display.GetComponent<TextMesh>();
        selfBoneTracker = GetComponent<BoneTracker>();
    }

    private void Update() {

        if (selfBoneTracker.bones.Count == 0) {
            textMesh.text = idleText;
            return;
        }
        
        if (selfBoneTracker.bones.Count > 1) {
            textMesh.text = "ONLY ONE BONE ALLOWED";
            return;
        }

        PlayEntity stats = selfBoneTracker.bones[0].GetComponent<PlayEntity>();

        textMesh.text = stats.getDescription();
    }
}
