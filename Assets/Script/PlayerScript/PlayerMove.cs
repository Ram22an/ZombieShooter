using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerAnimation playerAnimation;
    private Rigidbody2D MyBody;
    private float Move_ForceX = 2f, Move_ForceY = 2f;
    void Awake()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
        MyBody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        /**if (moveX != 0)
        {
            Vector3 localScale = transform.localScale;
            localScale.x = moveX > 0 ? -Mathf.Abs(localScale.x) : Mathf.Abs(localScale.x);
            transform.localScale = localScale;
        }**/
        if (moveX >0)
        {
            gameObject.transform.localScale = new Vector2(-1f, 1f);
        }
        if(moveX<0)
        {
            gameObject.transform.localScale = new Vector2(1f, 1f);
        }
        if (moveY != 0 || moveX != 0)
        {
            playerAnimation.PlayerWalking(true);
        }
        else
        {
            playerAnimation.PlayerWalking(false);
        }

        Vector2 movement = new Vector2(moveX * Move_ForceX, moveY* Move_ForceY);
            MyBody.MovePosition(MyBody.position + movement * Time.fixedDeltaTime);
    }

}//class
