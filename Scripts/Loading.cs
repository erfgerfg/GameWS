using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    private float schetchik = 0;
    public float speedLoad;
    public Slider slider;
    public int sc;

    private void Start()
    {
        slider.maxValue = speedLoad;
        slider.minValue = 0;
    }

    public void Update()
    {
        schetchik += Time.deltaTime;
        slider.value = schetchik;
        if (schetchik >= speedLoad)
            SceneManager.LoadScene(sc);
    }
}
