using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        if (Mainmenu.Level == 0)
        {
            Player.transform.position = new Vector3(20, 1, 40);
        }
        else if(Mainmenu.Level == 1)
        {
            Player.transform.position = new Vector3(50, 1, 40);
        }
        else
        {
            Player.transform.position = new Vector3(95, 1, 35);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
