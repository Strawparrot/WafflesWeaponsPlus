using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class IntroTextController : MonoBehaviour
{
    public bool firstTime;

    public GameObject page2Screen;
    public GameObject[] deactivateOnIntroEnd;

    public Slider soundSlider;
    public Slider musicSlider;
    public AudioMixer[] audmix;
    public bool introOver;
}
