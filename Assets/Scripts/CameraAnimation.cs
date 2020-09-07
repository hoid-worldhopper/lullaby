using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    public CharacterController playerController;
    public Animation anim;
    
    private bool isMoving;
    private bool left;
    private bool right;



    void CameraAnimations()
    {
        if(playerController.isGrounded == true)
        {
            if(isMoving == true)
            {
                if(left == true)
                {
                    LeftAnimation();
                }
                if (right == true)
                {
                    RightAnimation();
                }
                else
                {

                }
            }
        }
    }

    void LeftAnimation()
    {
        if (!anim.isPlaying)
        {
            anim.Play("walkLeft");
            left = false;
            right = true;
        }
    }

    void RightAnimation()
    {
        if (!anim.isPlaying)
        {
            anim.Play("walkLeft");
            left = false;
            right = true;
        }
    }

    void IdleAnimation()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        left = true;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if(inputX != 0 || inputY != 0)
        {

        }
    }
}
