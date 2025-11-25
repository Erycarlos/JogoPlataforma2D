using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public static int deathCount = 0;
    public TextMeshProUGUI deathText;

    void Awake()
    {
        // Mantém o contador ao trocar de cena
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        UpdateDeathText();
    }

    public void AddDeath()
    {
        deathCount++;
        UpdateDeathText();
    }

    void UpdateDeathText()
    {
        if (deathText != null)
            deathText.text = "Mortes: " + deathCount.ToString();
    }
}