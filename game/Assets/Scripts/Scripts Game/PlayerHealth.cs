using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    [Tooltip("Transform que representa o último checkpoint atingido")]
    public Transform respawnPoint;

    public GameObject gameOverPanel; // <-- UI de "Você perdeu! Pressione F"
    
    private CharacterController controller;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        controller = GetComponent<CharacterController>();

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (isDead && Input.GetKeyDown(KeyCode.F))
        {
            Respawn();
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        currentHealth = 0;
        isDead = true;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }

    private void Respawn()
    {
        currentHealth = maxHealth;
        isDead = false;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (respawnPoint != null)
        {
            controller.enabled = false;
            transform.position = respawnPoint.position;
            controller.enabled = true;
        }
        else
        {
            Debug.LogWarning("Nenhum ponto de respawn definido!");
        }
    }

    public void SetRespawnPoint(Transform newPoint)
    {
        respawnPoint = newPoint;
    }
}
