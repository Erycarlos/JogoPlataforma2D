using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    private DeathCounter contador;

    void Start()
    {
        contador = FindObjectOfType<DeathCounter>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (contador != null)
                contador.AddDeath();

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
