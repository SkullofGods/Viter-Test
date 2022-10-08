using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject volumePanel;
    public TextMeshProUGUI volumePercent;
    public Slider slider;

    private void Awake()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        GetComponent<AudioSource>().volume = slider.value / 100f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void SoundButton()
    {
        volumePanel.SetActive(true);
    }

    public void Close()
    {
        volumePanel.SetActive(false);
    }
    
    public void VolumeSlider(float sliderValue)
    {
        GetComponent<AudioSource>().volume = sliderValue / 100f;
        volumePercent.text = (sliderValue).ToString() + "%";
        PlayerPrefs.SetFloat("Volume", sliderValue);
    }
}
