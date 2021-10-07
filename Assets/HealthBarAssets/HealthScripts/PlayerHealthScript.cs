using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damageAmount = 10;

    public HealthBarScript healthBar;
    public GameOverScript GameOverScreen;
  

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //Detect collision between the gameobjects with colliders attacted
    private void OnCollisionEnter(Collision collision)
    {
        //check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Obstacle")
        {
            //If game object has same tag take damage
            //game object must have rigid body and be kinematic
            TakeDamage(damageAmount);
        }

        //check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "InstantDeath")
        {
            //If game object has same tag take damage
            //Player must have rigid body and is kinematic unchecked

            //Enemy object must have box collider with is trigger unchecked
            //rigid body obtional
            TakeDamage(100);
        }
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            GameOverScreen.Setup();
            healthBar.SetOff();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
