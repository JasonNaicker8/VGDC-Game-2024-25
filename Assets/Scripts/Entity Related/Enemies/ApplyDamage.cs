using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDamage : MonoBehaviour
{
    /* -----------------------------------------------------------
 * Author: Jason Naicker
 * 
 * 
 * Modified By:
 * 
 */// --------------------------------------------------------

    /* -----------------------------------------------------------
     * Purpose: Creating a function to apply damage to the enemey on call.
     * Works with EnemyStats script.
     * Creates a temporary health variable to track damage, and set the actual health to 
       temporary variable when damage function is called.
     */// --------------------------------------------------------


    // Start is called before the first frame update
    public GameObject Enemy; // Sets object for damage to be applied to
    public float health; // class serialized variable for actual health variable

    //Temp values
    public static float normalDamageApplied = 25f; // Amount of damage applied
    public float fireDamageApplied = 2f;
    public float iceDamageApplied = 15f;

    float[] damageType = new float[3]; // Array for damage types


    void Start()
    {
        EnemyStats enemyStats = Enemy.GetComponent<EnemyStats>(); //Get enemy actual health
        health = enemyStats.enemyHealth; // Initialize health variable to actual health.
        Enemy = this.gameObject; // Initialize enemy
        damageType[0] = normalDamageApplied;
        damageType[1] = fireDamageApplied;
        damageType[2] = iceDamageApplied;

    }

    // Update is called once per frame
    void Update()
    {
        health = Enemy.GetComponent<EnemyStats>().enemyHealth; //Track the enemy actual health in this variable
        Debug.Log(damageType.Length);
    }

    /// <summary>
    /// a call method to apply damage
    /// </summary>
    /// <returns></returns>
    /// 

    public float applyDamage(int x) // Apply damage function
    {

        if (health > 0f)
        {
            health -= damageType[x];// subtract health

        }

        return health; //return variable health to be applied to actual health.


    }

}
