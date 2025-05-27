using UnityEngine;

public class LavaJumpHint : MonoBehaviour
{
    public GameObject jumpHintText;
    private bool playerNear = false;
    private bool hintShown = false;

    void Update()
    {
        if (playerNear && !hintShown && Input.GetKeyDown(KeyCode.Space))
        {
            hintShown = true;
            if (jumpHintText != null)
            {
                jumpHintText.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hintShown)
        {
            playerNear = true;
            if (jumpHintText != null)
            {
                jumpHintText.SetActive(true);
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