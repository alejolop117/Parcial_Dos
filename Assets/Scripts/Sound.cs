using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public DataSO channel;
    [SerializeField] AudioClip clip;

    AudioSource player;

    private void Awake()
    {
        player = GetComponent<AudioSource>();
        player.clip = clip;
    }

    private void OnEnable()
    {
        channel.OnMovement += steps;
       
    }

    private void OnDisable()
    {
        channel.OnMovement -= steps;
    }

    public void steps()
    {
        
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
            player.Play();
    }
}
