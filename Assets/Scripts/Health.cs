using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthtext;
    public int maxHealth = 100;
    public TextMeshProUGUI healthText;
    public float invincibilityTImer = 1.0f;
    public bool canTakeDamage = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if(canTakeDamage) 
            TakeDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.I))
    }
    { HealDamage(15);

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthText.text = "Health: " + health;

        if (health <= 0)

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void HealDamage(int healing)

    {
        health += healing;

        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        healthText.text = "Health: " + Health;
    }
}

IEnumerator InvincibilityCo()
{
    Debug.Log("Can no longer take damage");
    yield return new WaitForSeconds(invincibilityTimer);
    canTakeDamage
}
