using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{
    public float toxicity = 0;
    public float magic = 0;
    public float tenderness = 0;
    public float mass = 1;

    public int getCost() {
        float costPerKilo = (5 * ((1 + magic) * (1 + tenderness))) / (1 + (3 * toxicity));

        return (int)(costPerKilo * mass);
    }

    private string shortenString(string x, int targetLen = 4) {
        while (x.Length > targetLen) {
            x = x.Remove(x.Length - 1);
        }

        return x;
    }

    public string toString() {
        string result = "";

        result += "Toxicity:   " + shortenString(toxicity.ToString()) + "\n";
        result += "Magic:      " + shortenString(magic.ToString()) + "\n";
        result += "Tenderness: " + shortenString(tenderness.ToString()) + "\n";
        result += "Mass:       " + shortenString(mass.ToString()) +     "\n";

        return result;
    }
}
