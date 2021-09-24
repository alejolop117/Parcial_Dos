using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "ScriptableObjects/DataSO")]
public class DataSO : ScriptableObject
{
    
    public event UnityAction OnMovement;

    public void On_movement() {

        if(OnMovement != null) {
            OnMovement();
        }
    }
}
