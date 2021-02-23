using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightPlayer1 : MonoBehaviour
{
    public Animator theAnim;
    public Stats statistiques;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        theAnim = gameObject.GetComponent<Animator>();
        statistiques = gameObject.GetComponent<Stats>();
        player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        BigPunch2(); 
        BigPunch1();
        Punch1();
        Punch2();
        isAlive();
    }

    public void Hit()
    {
        if (Mathf.Abs(gameObject.transform.position.x - player2.transform.position.x) < 7f)
        {
            player2.GetComponent<Stats>().getHit(1);
            player2.GetComponent<Animator>().SetBool("getHit", true);
        }
    }

    public void EndHit()
    {
        player2.GetComponent<Animator>().SetBool("getHit", false);
    }

    public void BigPunch1()
    {
        if (Input.GetKey("t")) { 
            theAnim.SetBool("bigPunch1", true);
        }
        else { 
            theAnim.SetBool("bigPunch1", false);
        }
    }

    public void Punch1()
    {
        if (Input.GetKey("g")) { 
            theAnim.SetBool("punch1", true);
        }
        else { 
            theAnim.SetBool("punch1", false);
        }
    }

    public void BigPunch2()
    {
        if (Input.GetKey("y")) { 
            theAnim.SetBool("bigPunch2", true);
        }
        else { 
            theAnim.SetBool("bigPunch2", false);
        }
    }

    public void Punch2()
    {
        if (Input.GetKey("h"))
        {
            theAnim.SetBool("punch2", true);
        }
        else { 
            theAnim.SetBool("punch2", false);
        }
    }

    public void isAlive()
    {
        if(statistiques.currentHealth <= 0)
        {
            theAnim.SetBool("mort", true);
        }
    }
}
