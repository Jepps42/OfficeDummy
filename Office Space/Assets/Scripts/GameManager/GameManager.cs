using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalPapers = 5;
    private int collectedPapers = 0;

    public TextMeshProUGUI paperText;

    

    public Door door;

    private void Awake()
    {
        instance = this;
    }

    public void CollectPaper()
    {
        collectedPapers++;
        paperText.text = "Collect Papers: " + collectedPapers + "/5";
        //Debug.Log("Papers: " + collectedPapers + "/" + totalPapers);

        if (collectedPapers >= totalPapers)
        {
            door.UnlockDoor();
        }
    }
}
