using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManage : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider volumeslider;
    public GameObject sound;
    private AudioSource gameAudio;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }
    }

    public void changevolume()
    {
        AudioListener.volume = volumeslider.value;
        save();
    }

    private void load()
    {
        volumeslider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeslider.value);
    }
}
