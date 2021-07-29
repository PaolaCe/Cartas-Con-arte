using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardManager : MonoBehaviour
{
    public int handNum;
    public GameManager GM;
    public Player P1;
    public Player P2;
    Text text;
    Button bttn;
    // Start is called before the first frame update
    void Start()
    {
        this.GM = GameObject.FindObjectOfType<GameManager>();
         text = GetComponentInChildren<Text>();
         bttn= GetComponent<Button>();
    }

    void Update()
    {
        cardManager();
    }

    void cardManager()
    {

        if (GM.turno % 2 == P1.playerNum)
        {
            if (P1.hand[handNum] != null)
            {
                bttn.enabled = true;
                text.text = P1.hand[handNum].name;
            }
            else
            {
                text.text = "";
                bttn.enabled = false;
            }
        }
        else
        {
            if (P2.hand[handNum] != null)
            {
                bttn.enabled = true;
                text.text = P2.hand[handNum].name;
            }
            else
            {
                text.text = "";
                bttn.enabled = false;
            }

        }
    
    }

    public void onclick()
    {
        if (GM.turno % 2 == P1.playerNum)
        {
            if (P1.hand[handNum].manaCost <= P1.mana)
            {
                P1.mana -= P1.hand[handNum].manaCost;
                P2.health -= P1.hand[handNum].atk;
                P1.hand[handNum] = null;

            }
        }
        else
        {
            if (P2.hand[handNum].manaCost <= P2.mana)
            {
                P2.mana -= P2.hand[handNum].manaCost;
                P1.health -= P2.hand[handNum].atk;
                P2.hand[handNum] = null;

            }

        }
    }
}
