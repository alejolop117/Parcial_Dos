using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour, Iinteractable {

    Renderer playerRenderer;
    Renderer myRenderer;
    PlayerMovement speedPlayer;
    float newSpeed = 4f;
   
    public void Interact(Player player) {
        ChangeColor(player);
        ChangeSpeed(player);
    }

    void ChangeColor(Player player) {
        playerRenderer = player.GetComponentInChildren<Renderer>();
        myRenderer = GetComponent<Renderer>();
        playerRenderer.material.color = myRenderer.material.color;
    }

    void ChangeSpeed(Player player) {
        speedPlayer = player.GetComponent<PlayerMovement>();
        speedPlayer.magnitud = newSpeed;
    }
}
