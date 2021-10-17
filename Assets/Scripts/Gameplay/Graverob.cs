using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Graverob : MonoBehaviour
{
    public int sceneIndex = 1;
    public int cost = 50;
    public int costIncrement = 5;
    public TextMesh costDisplay;

    private void Update() {
        costDisplay.text = cost.ToString() + "$";
    }

    private void OnMouseDown() {
        if (PlayerStats.money < cost) {
            return;
        }        

        PlayerStats.money -= cost;

        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);

        cost += costIncrement;
    }
}
