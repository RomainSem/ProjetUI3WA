using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePref : MonoBehaviour
{

    private void Awake()
    {
        _keyName= gameObject.name;
        string prefValue = PlayerPrefs.GetString(_keyName);
        if (prefValue != "False")
        {
            GetComponent<Toggle>().isOn = true;
        }
        else
        {
            GetComponent<Toggle>().isOn = false;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TogglePrefValue(bool isOn)
    {
        PlayerPrefs.SetString(_keyName, isOn.ToString());
    }

    private string _keyName;
}
