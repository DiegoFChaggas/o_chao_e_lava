using UnityEngine;

public class InteractionHint : MonoBehaviour
{
    public GameObject hintText;
    private bool playerNear = false;
    private bool hasJumped = false;

    void Update()
    {
        if (playerNear && !hasJumped && Input.GetKeyDown(KeyCode.Space))
        {
            hasJumped = true;
            if (hintText != null)
            {
                hintText.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasJumped)
        {
            playerNear = true;
            if (hintText != null)
            {
                hintText.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}