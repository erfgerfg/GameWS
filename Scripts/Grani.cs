using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Grani : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Eat" || coll.gameObject.tag == "BadEat" || coll.gameObject.tag == "Wolf")
        {
            Destroy(coll.gameObject);
        }
    }
}
