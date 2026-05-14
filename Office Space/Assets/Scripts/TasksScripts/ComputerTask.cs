using System.Collections;
using UnityEngine;

public class ComputerTask : MonoBehaviour
{

    private CharacterController playerController;

    public float interactionTime = 2.0f;

    private bool isInteracting = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableCharacterController()
    {
        if (isInteracting == true)
        {
            StartCoroutine(DisableRoutine());
        }
    }

    public IEnumerator DisableRoutine()
    {
        Debug.Log("Player just interacted");
        playerController.enabled = false;
            yield return new WaitForSeconds(interactionTime);
        playerController.enabled = true;
    }

    
}
