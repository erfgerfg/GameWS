using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float health;
    public float health2;
    public float maxHealth;
    public Slider healthSlider;
    public Slider healthSlider2;
    public float hungr;
    public float maxHungr;
    public Slider hungrSlider;
    public float gribHungr = 5;
    public float gribDamage = 30;

    void Start()
    {
        hungr = maxHungr;
        hungrSlider.maxValue = maxHungr;
        hungrSlider.minValue = 0;
        healthSlider.maxValue = maxHealth;
        healthSlider.minValue = 0;
        healthSlider2.maxValue = maxHealth;
        healthSlider2.minValue = 0;
    }
    
    void ChangeScene()
    {
        if(health < 0)
            SceneManager.LoadScene(6);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Eat")
        {
            hungr += gribHungr;
            Destroy(coll.gameObject);
        }
        if(coll.gameObject.tag == "BadEat")
        {
            health -= gribDamage;
            Destroy(coll.gameObject);
        }
        if(coll.gameObject.tag == "Wolf")
        {
            health -= 30;
        }
    }

    public void TakeHit(float damage)
    {
        health -= damage;
    }

    public void SetHealth(float bonusHealth)
    {
        health += bonusHealth;

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    void Update()
    {
        if (hungr > 0)
            hungr -= Time.deltaTime;
        if (hungr > maxHungr)
            hungr = maxHungr;
        if (hungr <= 0)
            health -= Time.deltaTime;
        if (health < 0)
            SceneManager.LoadScene(6);

        if (health < health2)
        {
                health2 -= Time.deltaTime * 30;
        }
        else if (health2 <= health)
        {
            health2 = health;
        }

        hungrSlider.value = hungr;
        healthSlider.value = health;
        healthSlider2.value = health2;
    }
}