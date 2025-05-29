using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public int damageAmount = 100;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.GetComponent<PlayerHealth>();

        if (health != null)
        {
            health.TakeDamage(damageAmount);
        }
    }
}
