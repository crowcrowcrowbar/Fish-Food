using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTake : MonoBehaviour, IInteractable
{
    public bool isTaken = false;
    public void Interact()
    { 
        if (!isTaken)
        {
            Debug.Log("item taken.");
            isTaken = true;
            Destroy(this.gameObject);
        }
    }
}
