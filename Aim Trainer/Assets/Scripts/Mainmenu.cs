using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public static int Level;
    public Dropdown dropdown;
    public void PlayGame()
    {
        Level = dropdown.value;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
