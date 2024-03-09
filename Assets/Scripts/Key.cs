using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //Check if the player is the one that entered the trigger.
        {
            inventory.AddKey(); //Add the key to the player's inventory
            Destroy(this.gameObject); //Make the key disappear
        }
    }
}
