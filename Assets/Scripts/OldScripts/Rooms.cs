using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public bool ambientActivated;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            ambientActivated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            ambientActivated = false;
    }
}
