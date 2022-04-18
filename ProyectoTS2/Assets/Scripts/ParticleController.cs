using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject Particle;
    public Vector3 gravity = new Vector3(0.0f, -9.807f, 0.0f);
    public float m = 0.1f;
    Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 ac = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 vel = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        force = gravity * m;
        ac = force / m;
        vel += ac * Time.deltaTime;
        pos += vel * Time.deltaTime;
        Particle.transform.localPosition = pos;        
    }
}
