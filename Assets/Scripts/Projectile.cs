using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    protected Transform _target;

    [Header("Projectile Stats")]
    [SerializeField]
    [Range(1f, 100f)]
    protected float speed = 70f;

    [SerializeField]
    [Range(1f, 100f)]
    protected int damage = 50;

    [Header("Projectile Components")]
    protected GameObject impactParticle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Seek(Transform target)
    {
        _target = target;
    }
}
