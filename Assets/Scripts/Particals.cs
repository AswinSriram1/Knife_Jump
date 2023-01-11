using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particals : MonoBehaviour
{
    public static Particals instance;

    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle.Stop();
    }

    public void particlesPlay()
    {
        particle.Play();
    }
}
