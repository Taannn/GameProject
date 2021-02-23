using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    public float horizontalMovement;
    private Rigidbody rb;
    public float speed = 5000f;
    public Animator theAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        theAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        AnimationPlayer();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        rb.velocity = new Vector3(horizontalMovement, 0, 0);
    }

    public void AnimationPlayer()
    {
        if (horizontalMovement > .0000001f)
            theAnim.SetBool("avant", true);
        else if (horizontalMovement < -.0000001f)
            theAnim.SetBool("arriere", true);
        else
        {
            theAnim.SetBool("arriere", false);
            theAnim.SetBool("avant", false);
        }
    }
}
