using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public Transform spawnPlayer1;
    public Transform spawnPlayer2;
    public GameObject apparitionPlayer1;
    public GameObject apparitionPlayer2;
    public GameObject mainCam;
    public GameObject limitMap;
    // Start is called before the first frame update
    void Start()
    {
        GameObject p1 = Instantiate(player1, spawnPlayer1);
        GameObject p2 = Instantiate(player2, spawnPlayer2);
        StartCoroutine(Animation(p1, p2));
    }

    public IEnumerator Animation(GameObject p1, GameObject p2)
    {
        p1.GetComponent<Animator>().Play("Unarmed-DiveRoll-Forward1");
        yield return new WaitForSeconds(3f);
        apparitionPlayer1.SetActive(false);
        apparitionPlayer2.SetActive(true);
        p2.GetComponent<Animator>().Play("Unarmed-DiveRoll-Forward1");
        yield return new WaitForSeconds(3f);
        apparitionPlayer2.SetActive(false);
        mainCam.SetActive(true);
        limitMap.SetActive(true);
    }
}
