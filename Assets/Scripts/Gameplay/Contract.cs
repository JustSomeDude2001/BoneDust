using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contract : MonoBehaviour
{
    public int sceneIndex;
    public string bodyName;
    public string bodyDescription;
    public int cost;

    public TextMesh nameDisplay;
    public TextMesh descriptionDisplay;
    public TextMesh costDisplay;

    private void Update() {
        nameDisplay.text = bodyName;
        descriptionDisplay.text = bodyDescription;
        costDisplay.text = cost.ToString() + "$";
    }

    private void OnMouseDown() {
        if (PlayerStats.money < cost) {
            return;
        }        

        PlayerStats.money -= cost;

        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);

        Destroy(gameObject);
    }
}
