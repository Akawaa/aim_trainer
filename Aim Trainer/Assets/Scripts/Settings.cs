using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider sensslider;

    public Text SensNum;

    // Start is called before the first frame update
    void Start()
    {
        sensslider.value = CameraMovement.sensX / 50;
        SensNum.text = sensslider.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);

    }

    public void SetSensitivity(float sens)
    {
        CameraMovement.sensX = sens * 50;
        CameraMovement.sensY = sens * 50;
        SensNum.text = sensslider.value.ToString();
    }
}
