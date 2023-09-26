using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Target_System : MonoBehaviour
{
    public GameObject target;
    public float counter;
    public GameObject hardscreen;
    public GameObject mediumscreen;
    public GameObject easyscreen;
    public float num;
    
    private int randintx;
    private int randinty;

    Vector3 targetarea;


    // Start is called before the first frame update
    void Start()
    {
        if (Mainmenu.Level == 0)
        {
            targetarea = easyscreen.transform.position;
        }
        else if (Mainmenu.Level == 1)
        {
            targetarea = mediumscreen.transform.position;
        }
        else
        {
            targetarea = hardscreen.transform.position;
        }
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(num < counter)
        {
            System.Random rand = new System.Random();
            if (Mainmenu.Level == 0)
            {
                Debug.Log("Hello");
                randintx = rand.Next(-9, 9);
                randinty = rand.Next(-5, 5);
            }
            else if (Mainmenu.Level == 1)
            {
                randintx = rand.Next(-19, 19);
                randinty = rand.Next(-7, 7);
            }
            else
            {
                randintx = rand.Next(-24, 24);
                randinty = rand.Next(-9, 9);
            }

            var tar = Instantiate(target, new Vector3(targetarea.x + randintx, targetarea.y + randinty, targetarea.z - 0.2f), target.transform.rotation);
            num += 1;
        }
    }
}
