using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb; //Rigidbody для движения персонажа
    public float speed = 10; //Скорость персонажа
    private float runSpeed; //Скорость при ускорении
    public float staminValue = 5; // Время для стамины
    public Slider slider; // Слайдер для показателя стамины

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        slider.maxValue = 5; 
        slider.minValue = 0;
        slider.value = staminValue; // Макс и мин значения стамины и ее отображение
        runSpeed = speed * 2; // Скорость при ускорении в 2 раза больше обычной
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * x, speed * y); //Управление персонажем и его скорость
        if (Input.GetKey(KeyCode.LeftShift) && staminValue > 0)
        {
            staminValue -= Time.deltaTime;
            rb.velocity = new Vector2(runSpeed * x, runSpeed * y); //Ускорение если есть выносливость

        }
        if (!Input.GetKey(KeyCode.LeftShift) && staminValue < 5)
        {
            staminValue += Time.deltaTime;
            rb.velocity = new Vector2(speed * x, speed * y); //Если нет выносливости
        }
    }
}