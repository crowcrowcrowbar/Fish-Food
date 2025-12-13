using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProximityButton : MonoBehaviour
{
    public GameObject buttonPromptUI;
    public KeyCode interactionkey = KeyCode.E;
    public Collectible fish;
    public GameObject player;
    public bool isFishCaught = false;

    private bool playerInRange = false;
    // Start is called before the first frame update
    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(interactionkey) && playerInRange && !isFishCaught)
        {
            fish.CatchFish();
            isFishCaught = true;
            buttonPromptUI.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            buttonPromptUI.SetActive(true);
            Debug.Log("proximity entered");
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        playerInRange = false;
        buttonPromptUI.SetActive(false);
    }
}
