using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugL : MonoBehaviour
{
    public DataSO channel;
    string direction, text;
    private void OnEnable() {
        channel.OnMovement += ConsoleLog;
    }

    private void OnDisable() {
        channel.OnMovement -= ConsoleLog;
    }

    public void ConsoleLog() {
        direction = (Input.inputString).ToUpper();
        text = direction == "W" ? " ADELANTE" : direction == "S" ? " ATRAS" :
            direction == "A" ? " IZQUIERDA" : direction == "D" ? " DERECHA" : " null";

        Debug.Log(text);

    }
}
