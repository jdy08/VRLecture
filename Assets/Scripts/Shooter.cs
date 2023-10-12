using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunBerrelEnd;

    [SerializeField] ParticleSystem gunParticle;
    [SerializeField] AudioSource gunAudioSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, gunBerrelEnd.position, gunBerrelEnd.rotation);
        gunParticle.Play();
        gunAudioSource.Play();
    }
}
