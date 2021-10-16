using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private Text selfText;
    public GameObject playerInfo;

    private PlayerStats playerStats;
    void Start()
    {
        playerStats = playerInfo.GetComponent<PlayerStats>();
        selfText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        selfText.text = playerStats.money.ToString() + "$";
    }
}
