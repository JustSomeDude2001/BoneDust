using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private TextMesh selfText;
    public GameObject playerInfo;

    private PlayerStats playerStats;
    void Start()
    {
        playerStats = playerInfo.GetComponent<PlayerStats>();
        selfText = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        selfText.text = playerStats.money.ToString() + "$";
    }
}
