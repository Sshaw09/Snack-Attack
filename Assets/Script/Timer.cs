using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Device;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 60;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString();
            endScreen.gameObject.SetActive(false);
        }
        else
        {
            endScreen.gameObject.SetActive(true);
        }
         
    }

    void StartGame()
    {
        endScreen.gameObject.SetActive(false);
    }

}

