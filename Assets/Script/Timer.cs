using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimeScreen;
    float time;
    float timerInterval = 5f;
    float tick;

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Text>().text = time.ToString();
        time = Time.time;
        TimeScreen.GetComponent<TextMeshProUGUI>().text = $"{time}";
    }
}
