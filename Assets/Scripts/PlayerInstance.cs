using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{

    public PlayerInstantiate[] playerInstantiate;

    [System.Serializable]
    public struct PlayerInstantiate
    {
        public string NomePlayer;
        public int ID;
        public GameObject player;

    }



    void Start()
    {
        for(int i=0; i< playerInstantiate.Length; i++)
        {
            //Instanciando o personagem escolhido
            if(playerInstantiate[i].ID == GameController.Intance.playerID)
            {
                Instantiate(playerInstantiate[i].player, transform.position, Quaternion.identity);
            }
        }
    }

   
   
}
