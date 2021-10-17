using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    private TextMesh selfText;
    void Start()
    {
        selfText = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        selfText.text = PlayerStats.money.ToString() + "$";
    }
}
