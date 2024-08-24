using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator MyAnim;
    private void Awake()
    {
        MyAnim = GetComponent<Animator>();
    }
    public void PlayerWalking(bool Run)
    {
        MyAnim.SetBool("Run",Run);
    }
    public void PlayerAttacking()
    {
        MyAnim.SetTrigger("Attack");
    }
    public void SwitchWeponAnimation(int TypeWepon) 
    { 
        MyAnim.SetInteger("TypeWeapon",TypeWepon);
        MyAnim.SetTrigger("Switch");
    }
}//class
