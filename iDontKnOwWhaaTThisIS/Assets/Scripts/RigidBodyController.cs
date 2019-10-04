using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RigidBodyController : MonoBehaviour
{
    public Slider rb2dSlider;
    public Rigidbody2D rb2d;


    private void Start()
    {
        rb2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        rb2dSlider = gameObject.GetComponent<Slider>();

    }

    private void Update()
    {
        //rb2d.mass = rb2dSlider.value;
        //rb2d.gravityScale = rb2dSlider.value;
    }

    public void ChangeMass(float sld)
    {
        rb2d.mass = sld;
    }

    public void ChangeGravity(float sld)
    {
        rb2d.gravityScale = sld;
    }

    public void ChangeLinearDrag(float sld)
    {
        rb2d.drag = sld;
    }
}
