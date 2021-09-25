using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : MonoBehaviour, Iinteractable
{

    Renderer playerRenderer;
    Renderer myRenderer;
    MeshFilter grid;
    [SerializeField] Mesh shape;
    PlayerMovement speedPlayer;
    float newSpeed = 20f;

    public void Interact(Player player)
    {
        ChangeColor(player);
        ChangeSpeed(player);
        ChangeShape(player);

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

    void ChangeShape(Player player)
    {
        grid = player.gameObject.GetComponentInChildren<MeshFilter>();
        grid.mesh = shape;

    }

}
