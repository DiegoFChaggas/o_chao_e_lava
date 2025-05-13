using UnityEngine;
using TMPro;

public class MovementHintUI : MonoBehaviour
{
    public GameObject movementHintText;
    public GameObject sprintHintText;

    private bool hasMoved = false;
    private bool hasSprinted = false;

    [Tooltip("Tempo em segundos para mostrar a dica de correr após se movimentar")]
    public float delayToShowSprintHint = 2.0f;

    private float sprintHintTimer = 0f;
    private bool sprintHintWaiting = false;

    void Update()
    {
        if (!hasMoved && (Input.GetKeyDown(KeyCode.W) || 
                            Input.GetKeyDown(KeyCode.A) ||
                            Input.GetKeyDown(KeyCode.S) || 
                            Input.GetKeyDown(KeyCode.D)))
        {
            hasMoved = true;
            movementHintText.SetActive(false);

            // Começa a contagem para mostrar a dica de correr
            sprintHintWaiting = true;
            sprintHintTimer = 0f;
        }

        if (sprintHintWaiting)
        {
            sprintHintTimer += Time.deltaTime;
            if (sprintHintTimer >= delayToShowSprintHint)
            {
                sprintHintWaiting = false;
                sprintHintText.SetActive(true);
            }
        }

        if (!hasSprinted && sprintHintText.activeSelf && Input.GetKeyDown(KeyCode.LeftShift))
        {
            hasSprinted = true;
            sprintHintText.SetActive(false);
        }
    }
}