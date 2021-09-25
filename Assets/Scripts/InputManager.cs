using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public DataSO so;
    
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            so.On_movement();
            
        }
    }
}
