using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private LevelsLoader loader;

    private void Start ()
    {
        loader = GameObject.FindGameObjectWithTag("LevelsCanvas").GetComponent<LevelsLoader>();
    }
    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("ball"))
        {
            loader.StartNextLevel();
        }
    }
}
