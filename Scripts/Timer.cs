using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float TimeSchetchik;
    public Slider sliderTimer;
    public int sliderMax;
    public int sliderMin;

    void Start()
    {
        sliderTimer.maxValue = sliderMax;
        sliderTimer.minValue = sliderMin;
    }

    void Update()
    {
        sliderTimer.value = TimeSchetchik;
        TimeSchetchik -= Time.deltaTime;
        if( TimeSchetchik < 0 )
            SceneManager.LoadScene(7);
    }
}
