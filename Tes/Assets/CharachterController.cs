using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour
{
    new Rigidbody rigidbody;
    [SerializeField]float jumpPower;
    Animator anim;
    [SerializeField]float velocity;


    private void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        //dikey = z 
        //yatay = x

        //vertical = z
        //horizontal = x
        Debug.Log(Input.GetAxis("Vertical"));
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity/4);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(transform.up*jumpPower);
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
        }

        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));


    }
}
