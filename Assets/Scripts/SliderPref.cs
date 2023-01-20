using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderPref : MonoBehaviour
{
    private void Awake()
    {
        _keyName = gameObject.name;

        GetComponent<Slider>().value = PlayerPrefs.GetFloat(_keyName);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SliderPrefValue(float _value)
    {

        PlayerPrefs.SetFloat(_keyName, _value);
    }

    private string _keyName;
}
