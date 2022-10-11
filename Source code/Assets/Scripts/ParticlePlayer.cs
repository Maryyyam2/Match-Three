using System.Collections;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
    public ParticleSystem[] allParticles;
    public float lifetime = 1f;
    public bool destroyImmediate = true;

    // Start is called before the first frame update
    void Start()
    {
        allParticles = GetComponentsInChildren<ParticleSystem>();
        if (destroyImmediate)
        { 
        Destroy(gameObject, lifetime);
        }
    }
    public void Play()
    {
        foreach(ParticleSystem ps in allParticles)
        {
            ps.Stop();
            ps.Play();
        }
        Destroy(gameObject, lifetime);
    }
}
