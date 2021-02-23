using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightPlayer2 : MonoBehaviour
{
    public Animator theAnim;
    public Stats statistiques;
    public GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        theAnim = gameObject.GetComponent<Animator>();
        statistiques = gameObject.GetComponent<Stats>();
        player1 = GameObject.FindGameObjectWithTag("Player1");
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
        if (Mathf.Abs(gameObject.transform.position.x - player1.transform.position.x) < 7f)
        {
            player1.GetComponent<Stats>().getHit(1);
            player1.GetComponent<Animator>().SetBool("getHit", true);
        }
    }

    public void EndHit()
    {
        player1.GetComponent<Animator>().SetBool("getHit", false);
    }

    public void BigPunch1()
    {
        if (Input.GetKey("[4]")) { 
            theAnim.SetBool("bigPunch1", true);
        }
        else { 
            theAnim.SetBool("bigPunch1", false);
        }
    }

    public void Punch1()
    {
        if (Input.GetKey("[1]")) { 
            theAnim.SetBool("punch1", true);
        }
        else { 
            theAnim.SetBool("punch1", false);
        }
    }

    public void BigPunch2()
    {
        if (Input.GetKey("[5]")) { 
            theAnim.SetBool("bigPunch2", true);
        }
        else { 
            theAnim.SetBool("bigPunch2", false);
        }
    }

    public void Punch2()
    {
        if (Input.GetKey("[2]"))
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
