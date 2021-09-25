using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour, Iinteractable
{
    Renderer playerRenderer;
    Renderer myRenderer;
    PlayerMovement speedPlayer;
    float newSpeed = 15f;
    private Vector3 scaleChange;

    public void Interact(Player player)
    {
        ChangeColor(player);
        ChangeSpeed(player);
        ChangeScale(player);
    }

    void ChangeColor(Player player)
    {
        playerRenderer = player.GetComponentInChildren<Renderer>();
        myRenderer = GetComponent<Renderer>();
        playerRenderer.material.color = myRenderer.material.color;
    }

    void ChangeSpeed(Player player)
    {
        speedPlayer = player.GetComponent<PlayerMovement>();
        speedPlayer.magnitud = newSpeed;
    }
    void ChangeScale(Player player)
    {
        scaleChange = new Vector3(2f, 2f, 2f);
        player.transform.localScale = scaleChange;
    }
}
