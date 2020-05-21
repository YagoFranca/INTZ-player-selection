using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{

    public Selection[] select;

    [System.Serializable]
    public struct Selection 
    {
        public string playerName;
        public Button button;
        
    }

    public void SelectPlayer(int id)
    {
        for(int i=0; i < select.Length; i++)
        {
            GameController.Intance.playerID = id;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameSceane");  
    }
}
