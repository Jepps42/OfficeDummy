using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isUnlocked = false;

    public Animator animator; // optional if you want animation

    public void UnlockDoor()
    {
        isUnlocked = true;
        Debug.Log("You unlocked the Lunch Room!");
        Destroy(this.gameObject);


        if (animator != null)
        {
            animator.SetTrigger("Open");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isUnlocked)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        if (animator != null)
        {
            animator.SetTrigger("Open");
        }
        else
        {
            // fallback: just disable the door
            gameObject.SetActive(false);
        }
    }
}
