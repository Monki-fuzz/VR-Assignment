using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("fire"))
        {
            other.GetComponent<ParticleSystem>().Stop();
        }
    }
}
