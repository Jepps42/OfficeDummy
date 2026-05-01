using UnityEngine;

public class ComputerTask : MonoBehaviour
{

    private PlayerController playerController;

    public float interactionTime = 2.0f;

    private bool isInteracting = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
