using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1M : MonoBehaviour
{
    public Player P;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = P.mana.ToString() + " / " +P.MaxMana.ToString() ;
    }
}
