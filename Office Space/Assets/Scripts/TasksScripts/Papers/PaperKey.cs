using UnityEngine;

public class Paper : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Hit paper");
        if (hit.collider.CompareTag("Papers"))
        {
            GameManager.instance.CollectPaper();
            Destroy(hit.gameObject);
        }
    }
}
