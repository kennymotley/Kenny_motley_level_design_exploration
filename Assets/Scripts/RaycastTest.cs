using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //If the player clicks the left mouse button
        {
            RaycastHit hit; //Have a variable to store what is hit by the raycast.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Get a ray from the camera to the mouse position
            if (Physics.Raycast(ray, out hit)) //Check if the ray hits an object with a collider.
            {
                Debug.Log(hit.collider.gameObject.name); //Toss a debug log with the name of the object being hit.
            }
        }
    }
}
