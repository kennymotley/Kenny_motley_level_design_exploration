using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float targetPoints;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>(); //One way to get reference via a single object in the scene with a tag.
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collidingObject)
    {
        if(collidingObject.gameObject.CompareTag("Projectile")) //Check if the colliding object is a projectile.
        {
            Debug.Log("Earned " + targetPoints + " points!"); //Display the number of points earned for hitting the target.

            scoreManager.AddScore(targetPoints);

            Destroy(collidingObject.gameObject); //Destroy the cannonball
        }
    }
}
