using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall; //The cannonball prefab
    public Transform cannonBallSpawnLocation; //The location the cannonball should spawn
    public float cannonBallForce; //The force of the cannonball being shot
    public float rotationSpeed = 20f;
    public float cbForceAdjustment = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.eulerAngles += new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime; //Rotate the cannon up while holding W
            
            /*Vector3 ea = this.transform.rotation.eulerAngles;

            ea += (new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime);
            ea.z = Mathf.Clamp(ea.z, -135f, 10f);

            this.transform.rotation = Quaternion.Euler(ea);*/
        }

        if (Input.GetKey(KeyCode.S))
        {
            /*
            Vector3 ea = this.transform.rotation.eulerAngles;

            ea -= (new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime);
            ea.z = Mathf.Clamp(ea.z, -135f, 10f);

            this.transform.rotation = Quaternion.Euler(ea);
            */

            
            this.transform.eulerAngles -= (new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime); //Rotate the cannon down while holding S
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            cannonBallForce -= cbForceAdjustment;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            cannonBallForce += cbForceAdjustment;
        }

        if(Input.GetKeyDown(KeyCode.Space)) //Check for player input
        {
            GameObject cb = Instantiate(cannonBall, cannonBallSpawnLocation.position, this.transform.rotation); //Spawn the cannonball into a variable so we have reference to it.

            cb.GetComponent<Rigidbody>().AddForce(this.transform.up * cannonBallForce); //Get reference to the rigidbody on the cannonball and add force.
        }
    }
}
