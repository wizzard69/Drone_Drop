using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float thrustForce;
    public Rigidbody rb;
    public Animator animator;

    private Vector3 thrust;
    private Battery battery;
    private Animator droneAnimator;

    private void Start()
    {
        battery = GetComponent<Battery>();
        droneAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        thrust = Vector3.zero;
        animator.SetBool("IsThrust", false);
        animator.SetBool("IsFlight", true);
        droneAnimator.SetBool("DroneLeft", false);
        droneAnimator.SetBool("DroneRight", false);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (battery.currentCharge > 0)
            {
                thrust += Vector3.up * thrustForce;
                battery.currentCharge -= battery.dechargeRate * Time.deltaTime;
                animator.SetBool("IsThrust", true);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (battery.currentCharge > 0)
            {
                thrust += Vector3.left * thrustForce;
                battery.currentCharge -= battery.dechargeRate * Time.deltaTime;
                animator.SetBool("IsThrust", true);
                droneAnimator.SetBool("DroneLeft",true);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (battery.currentCharge > 0)
            {
                thrust += Vector3.right * thrustForce;
                battery.currentCharge -= battery.dechargeRate * Time.deltaTime;
                animator.SetBool("IsThrust", true);
                droneAnimator.SetBool("DroneRight", true);
            }
        }

        if (rb.IsSleeping())
        {
            animator.SetBool("IsThrust", false);
            animator.SetBool("IsFlight", false);
		}

        //float minRotation = -15;
        //float maxRotation = 15;
        //Vector3 currentRotation = transform.localRotation.eulerAngles;
        //currentRotation.z = Mathf.Clamp(currentRotation.z, minRotation, maxRotation);
        //transform.localRotation = Quaternion.Euler(currentRotation);
    }

    void FixedUpdate()
    {
        //rb.AddRelativeForce(thrust);
        rb.AddForce(thrust, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //> 2
        //print(collision.relativeVelocity.magnitude);
    }
}
