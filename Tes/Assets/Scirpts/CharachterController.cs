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
        moveTheJack();

        


    }

    void moveTheJack()
    {
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.S))
        {
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 8);
            }

            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 8);
            }
            else
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 4);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("was");
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 2f);
            }

            else if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("was");
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 2f);
            }
            else
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity);
            }
        }

        else if (Input.GetKey(KeyCode.D)){
            transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 2f);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity / 2f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(transform.up * jumpPower);
        }

        

        

        
    }
}
