using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb; //Rigidbody ��� �������� ���������
    public float speed = 10; //�������� ���������
    private float runSpeed; //�������� ��� ���������
    public float staminValue = 5; // ����� ��� �������
    public Slider slider; // ������� ��� ���������� �������

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        slider.maxValue = 5; 
        slider.minValue = 0;
        slider.value = staminValue; // ���� � ��� �������� ������� � �� �����������
        runSpeed = speed * 2; // �������� ��� ��������� � 2 ���� ������ �������
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(speed * x, speed * y); //���������� ���������� � ��� ��������
        if (Input.GetKey(KeyCode.LeftShift) && staminValue > 0)
        {
            staminValue -= Time.deltaTime;
            rb.velocity = new Vector2(runSpeed * x, runSpeed * y); //��������� ���� ���� ������������

        }
        if (!Input.GetKey(KeyCode.LeftShift) && staminValue < 5)
        {
            staminValue += Time.deltaTime;
            rb.velocity = new Vector2(speed * x, speed * y); //���� ��� ������������
        }
    }
}