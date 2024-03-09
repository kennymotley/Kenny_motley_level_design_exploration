using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyPathing : MonoBehaviour
{
    public List<Transform> patrolPaths;

    private int patrolPathIndex = 0;

    private NavMeshAgent navMeshAgent;

    private bool isChasingPlayer = false;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

        navMeshAgent.destination = patrolPaths[patrolPathIndex].position;

        //navMeshAgent.destination = patrolPath1.position;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, 10f))
        {
            if(hit.collider.gameObject.CompareTag("Player"))
            {
                navMeshAgent.destination = hit.collider.transform.position;
                isChasingPlayer = true;
            }
        }


        if (navMeshAgent.remainingDistance < 0.5f)
        {
            if (!isChasingPlayer)
            {
                patrolPathIndex++;

                if (patrolPathIndex >= patrolPaths.Count)
                {
                    patrolPathIndex = 0;
                }

                navMeshAgent.destination = patrolPaths[patrolPathIndex].position;
            }
            else if (isChasingPlayer)
            {
                if(Vector3.Distance(this.transform.position, player.transform.position) < 0.5f)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    isChasingPlayer = false;

                    navMeshAgent.destination = patrolPaths[patrolPathIndex].position;
                }
            }
        }
        
    }
}
