using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player player;
    GameObject collidedObject;

    private void OnCollisionEnter(Collision collision) {
        collidedObject = collision.gameObject;
        Iinteractable interactable = collidedObject.GetComponent<Iinteractable>();
        if (interactable == null) return;
        interactable.Interact(player);

    }
}
