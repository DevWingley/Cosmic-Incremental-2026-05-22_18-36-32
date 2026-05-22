using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Sources")]
    public AudioSource musicSource;

    [Header("UI")]
    public Slider musicSlider;
    public Slider sfxSlider;

    private float musicVolume = 1f;
    private float sfxVolume = 1f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        LoadVolume();
    }

    void Start()
    {
        musicSlider.value = musicVolume;
        sfxSlider.value = sfxVolume;

        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);

        ApplyVolume();
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = volume;
        ApplyVolume();
        SaveVolume();
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = volume;
        SaveVolume();
    }

    void ApplyVolume()
    {
        musicSource.volume = musicVolume;
    }

    void SaveVolume()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
        PlayerPrefs.Save();
    }

    void LoadVolume()
    {
        musicVolume = PlayerPrefs.GetFloat("MusicVolume", 1f);
        sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 1f);
    }

    public float GetSFXVolume()
    {
        return sfxVolume;
    }
}