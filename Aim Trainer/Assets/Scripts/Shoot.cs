using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Camera cam;
    public Target_System target_sys;
    public int score;
    public float accuracy;
    int amounthit;
    int amountshot;
    public static int totalscore;
    public static float totalaccuracy;

    public Animator glockanimation;
    public ParticleSystem muzzleflash;
    public AudioSource glocksound;
    public GameObject BulletHole;


    void Start()
    {
        amounthit = 0;
        amountshot = 0;
        cam = Camera.main;
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
            Debug.Log("fired!");
        }
    }

    void shoot()
    {
        glocksound.Play();
        muzzleflash.Play();
        glockanimation.SetTrigger("shoot");
        amountshot += 1;
        RaycastHit hit;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, Mathf.Infinity);
        if(hit.transform.gameObject.tag == "target")
        {
            Destroy(hit.transform.gameObject);
            target_sys.num = target_sys.num - 1;
            score += 100;
            amounthit += 1;
        }
        else
        {
            Instantiate(BulletHole, hit.point + (hit.normal * 0.01f), Quaternion.FromToRotation(Vector3.up, hit.normal));
        }
        accuracy = Mathf.CeilToInt(((float)amounthit / (float)amountshot) * 100);
    }
}
