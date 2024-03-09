using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonInteract : MonoBehaviour
{
    public float interactDistance = 5f;
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        DoorCheck();
    }

    void DoorCheck()
    {
        if (Input.GetKeyDown(KeyCode.E)) //If the player presses the 'E' button...
        {
            RaycastHit hit; //Create a variable to store the information of the hit object from the raycast
            if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, interactDistance)) //Create a ray from this object, going forward, for a set distance
            {
                //Debug.Log(hit.collider.name); //Display the name of the object hit by the raycast.

                if(hit.collider.CompareTag("Door")) //If the object hit by the raycast is a Door
                {
                    if(inventory.UseKey() == true)
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}
