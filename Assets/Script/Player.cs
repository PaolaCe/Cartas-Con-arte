using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health;
    public int mana;
    public int MaxMana;
    public int MaxHealth;
    public int playerNum;

    public GameManager GM;

    public Card[] hand= new Card[5];


    public List<Card> deck = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        this.health = MaxHealth;
        this.mana = MaxMana;

        this.GM = GameObject.FindObjectOfType<GameManager>(); 

        for (int i =0;i<5;i++)
        {
            Card handC = deck[0];
            hand[i] = handC;
            this.deck.RemoveAt(0);

        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }


}
