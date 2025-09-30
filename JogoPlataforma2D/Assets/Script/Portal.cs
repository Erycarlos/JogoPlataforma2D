using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string nomeDaCena;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && nomeDaCena != "2º Fase")
        {
            SceneManager.LoadScene(nomeDaCena);          
        }
    }
}       
    
     
        
    
