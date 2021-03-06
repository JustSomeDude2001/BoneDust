using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustSeller : MonoBehaviour
{
    private TextMesh display;

    private void Start() {
        display = GetComponent<TextMesh>();
        display.text = "Dust Seller";
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Dust") {
            return;
        }

        Debug.Log("Dust is sold!");

        Dust dustStats = other.gameObject.GetComponent<Dust>();

        int profit = dustStats.getCost(); 

        PlayerStats.money += profit;

        display.text = "Last sale:\n";
        display.text += dustStats.toString();
        display.text += "PROFIT: " + profit.ToString() + "$\n";

        Destroy(other.gameObject);
    }
}
