using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManipulation : MonoBehaviour
{
    public Light light1;
    public Light light2;
    public GameObject lightObject;

    // Start is called before the first frame update
    void Start()
    {
        // lightObject.GetComponent<Light>().color = Color.green;
        light1.color = Color.green;
        // light1.color = new Color(1f, .5f, .5f, .75f);
        // light1.color = new Color32(157, 232, 56, 255);
        // light1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
