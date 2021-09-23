using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour, Iinteractable {

    Renderer playerRenderer;
    Renderer myRenderer;
    PlayerMovement speedPlayer;
    float newSpeed = 4f;
   
    public void Interact(Player player) {
        playerRenderer = player.GetComponentInChildren<Renderer>();
        speedPlayer = player.GetComponent<PlayerMovement>();
        myRenderer = GetComponent<Renderer>();
        playerRenderer.material.color = myRenderer.material.color;
        speedPlayer.magnitud = newSpeed;
    }
}
