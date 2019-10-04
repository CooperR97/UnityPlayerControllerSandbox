using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassSlider : MonoBehaviour
{

    public Slider rb2dSlider;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        rb2dSlider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeMass();
    }

    public void ChangeMass()
    {

        rb2d.mass = rb2dSlider.value;
    }
}
