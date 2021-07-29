using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BttnManager : MonoBehaviour
{
    public GameManager GM;
    public Player P1;
    public Player P2;
    // Start is called before the first frame update
    void Start()
    {
        this.GM = GameObject.FindObjectOfType<GameManager>();

    }

    public void onBttnClick()
    {
        if (GM.turno % 2 == P1.playerNum)
        {
            P1.MaxMana += 1;
            P1.mana = P1.MaxMana;
            for (int i = 0; i < 5; i++)
            {
                Card handC = P1.deck[0];
                if (P1.hand[i] == null)
                {
                    P1.hand[i] = handC;
                    P1.deck.RemoveAt(0);
                    break;
                }
                if (i == 4)
                    P1.deck.RemoveAt(0);
            }
        }
        else
        {
            P2.MaxMana += 1;
            P2.mana = P2.MaxMana;
            for (int i = 0; i < 5; i++)
            {
                Card handC = P2.deck[0];
                if (P2.hand[i] == null)
                {
                    P2.hand[i] = handC;
                    P2.deck.RemoveAt(0);
                    break;
                }
                if (i == 4)
                    P2.deck.RemoveAt(0);
            }

        }
        GM.turno += 1;
    }

}
