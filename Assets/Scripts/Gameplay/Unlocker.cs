using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker : MonoBehaviour
{
    public GameObject unlocked;

    private void OnDestroy() {
        if (unlocked == null) {
            return;
        }

        unlocked.SetActive(true);
    }
}
