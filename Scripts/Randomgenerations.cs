using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomgenerations : MonoBehaviour
{
    public GameObject[] obj;
    public int maxEnemy = 5;

    public float timeSpawn = 2f;
    private float timer;

    public float distance = 3;
    private float Gribs = 0;

    private void Start()
    {
        timer = timeSpawn;
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                if (Gribs < 5)
                {
                    Gribs += 1;
                    Instantiate(obj[0], Random.insideUnitCircle * distance, Quaternion.identity, transform);
                }
                else
                {
                    Gribs = 0;
                    Instantiate(obj[1], Random.insideUnitCircle * distance, Quaternion.identity, transform);
                }
            }
        }
    }
}
