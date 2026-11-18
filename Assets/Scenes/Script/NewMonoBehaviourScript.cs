using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public AudioSource touchsound;
    public float keyinput;

    void Start()
    {
        touchsound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(Vector3.up*7, ForceMode.VelocityChange);
        }
        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().linearVelocity = new Vector3(keyinput, GetComponent<Rigidbody>().linearVelocity.y , 0);
    }
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Candy"))
        touchsound.Play();
    }
}
