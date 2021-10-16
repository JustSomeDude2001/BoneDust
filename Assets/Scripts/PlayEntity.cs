using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEntity : MonoBehaviour
{
    public float decay = 0.5f;
    public float soul = 0.5f;
    public float humidity = 0.5f;
    public float sponginess = 0.1f;
    public float mass = 1f;


    public float decayRate = 0.01f;
    public float soulShift = -0.01f;
    public float humidityChange = 0;
    public float sponginessChange = 0;
    public float massChange = 0;


    public float maxDecay = 1;
    public float maxSoul = 1;
    public float maxHumidity = 1;
    public float maxSponginess = 1;

    private bool isRuined() {
        if (decay >= maxDecay) {
            return true;
        }

        if (mass <= 0) {
            return true;
        }

        return false;
    }

    private void balance() {
        if (decay > maxDecay) {
            decay = maxDecay;
        }

        if (decay < 0) {
            decay = 0;
        }
        
        if (soul > maxSoul) {
            soul = maxSoul;
        }

        if (soul < 0) {
            soul = 0;
        }

        if (humidity > maxHumidity) {
            humidity = maxHumidity;
        }

        if (humidity < 0) {
            humidity = 0;
        }

        if (sponginess > maxSponginess) {
            sponginess = maxSponginess;
        }

        if (sponginess < 0) {
            sponginess = 0;
        }
    }

    private void advance() {
        decay += decayRate;
        soul += soulShift;
        humidity += humidityChange;
        sponginess += sponginessChange;
        mass += massChange;
    }

    private void notifyOnRuin() {
        //Pop up on bone being ruined
        return;
    }

    private void FixedUpdate() {
        if (isRuined()) {
            notifyOnRuin();
            Destroy(this.gameObject);
            return;
        }

        balance();
        advance();
    }
}
