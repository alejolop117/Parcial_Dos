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
    }

    private void OnEnable()
    {
        channel.OnMovement += Steps;
        player.clip = clip;
    }

    private void OnDisable()
    {
        channel.OnMovement -= Steps;
    }

    public void Steps()
    {
        
        if(Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical")) player.Play();
    }
}
