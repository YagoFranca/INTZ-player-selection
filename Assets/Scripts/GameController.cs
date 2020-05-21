using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerID;
    public static GameController Intance;
    public GameObject[] data;

    private void Awake()
    {
        Intance = this;
        
    }

    void Start()
    {
        //Procura outros gamecontrollers e deleta quando tem mais de um em cena
        data = GameObject.FindGameObjectsWithTag("GameController");

        if (data.Length >= 2)
        {
            Destroy(data[1]);
        }
    }



}
