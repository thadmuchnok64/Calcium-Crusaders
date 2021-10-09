using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float maxHealth;
    private float health;
    [SerializeField] float speed;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Returns the health of the entity
    /// </summary>
    /// <returns></returns>
    public float GetHealth()
    {
        return health;
    }
    /// <summary>
    /// Remove x health from the entity
    /// </summary>
    /// <param name="x"></param>
    public void TakeDamage(float x)
    {
        health -= x;
    }

    /// <summary>
    /// Heals entity with x health
    /// </summary>
    /// <param name="x"></param>
    public void Heal(float x)
    {
        health += x;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    /// <summary>
    /// returns the speed of the entity
    /// </summary>
    public float GetSpeed()
    {
        return speed;
    }



}
