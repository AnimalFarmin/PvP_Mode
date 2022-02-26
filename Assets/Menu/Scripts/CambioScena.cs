using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour
{

public int NumeroEsena;

public void Inicar()
{
    
    SceneManager.LoadScene(NumeroEsena);
}


}  
