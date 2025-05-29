using UnityEngine;

public class ClickHintTrigger : MonoBehaviour
{
    public GameObject clickHintText;

    private bool playerInside = false;
    private bool hasClicked = false;

    void Update()
    {
        if (playerInside && !hasClicked && Input.GetMouseButtonDown(0))
        {
            hasClicked = true;

            if (clickHintText != null)
                clickHintText.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasClicked)
        {
            playerInside = true;

            if (clickHintText != null)
                clickHintText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}
