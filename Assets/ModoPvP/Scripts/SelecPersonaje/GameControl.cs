using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
   public GameObject[] Characters;
   public Transform playerStartPosition;
   public int NumeroEsena;
   private string selectedCharacterDataName = "SelectedCharacter"; 
   int selectedCharacter;
   public GameObject playerObject;

    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObject = Instantiate(Characters[selectedCharacter],playerStartPosition.position,Characters[selectedCharacter].transform.rotation);
    }


public void Inicar()
{
    
    SceneManager.LoadScene(NumeroEsena);
}

}  

