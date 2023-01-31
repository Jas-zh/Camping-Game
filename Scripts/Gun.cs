using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 20f;
    public float range = 100f;
    public float ammo = 5f;
    public float fireRate = 15f;
    public ParticleSystem effects;
    public GameObject impactEffect;


    public Camera fpsCam;


    private float nextTimeToFire = 0f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            if (ammo > 0)
            {

                nextTimeToFire = Time.time + 1f / fireRate; 
                shoot();
                ammo -= 1;
            }
        }

        if(ammo >= 0)
        {
            if (Input.GetKeyDown("r"))
            {
                ammo = 2;
            }
        }
    }

    void shoot()
    {

        effects.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy target = hit.transform.GetComponent<Enemy>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));

            Destroy(impactGO, 2f);
        }
    }


}