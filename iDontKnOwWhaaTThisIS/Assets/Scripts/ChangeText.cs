using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private Text valText;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        valText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        valText.text = slider.value.ToString();
    }
}
