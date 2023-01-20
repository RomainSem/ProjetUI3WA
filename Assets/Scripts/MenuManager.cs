using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    [SerializeField] AudioSource _backgroundMusic;
    [SerializeField] Slider _masterVol;
    [SerializeField] Slider _musicVol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MusicVol()
    {
        _backgroundMusic.volume = _masterVol.value * _musicVol.value; 
    }
}
