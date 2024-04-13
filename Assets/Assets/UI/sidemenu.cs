using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidemenu : MonoBehaviour
{
    public GameObject sideMenuObject;
    public float moveTime;
    private Vector3 defaultPosition;
    public Transform endPosition;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = sideMenuObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
    }

    public void ToggleSideMenu()
    {
        sideMenuObject.transform.DOKill();

        if(sideMenuObject.transform.localPosition == defaultPosition)
        {
            sideMenuObject.transform.DoLocalMove(endPosition.localPosition, moveTime);
        }
        else
        {
            sideMenuObject.transform.DOLocalMove(defaultPosition, moveTime);
        }
    }
}
