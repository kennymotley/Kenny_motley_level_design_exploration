using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
IEnumerator TimerCo()
{
    Debug.Log("Started TimerCo");
    yield return null;
    Debug.Log("This is running on the second frame!");
    
    yield return new WaitForSeconds(3.0f);
    Debug.Log("Waited 3 seconds and now I'm posting this message!"); 
 

}