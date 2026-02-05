using UnityEngine;

public class AppleDestroyer : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Apple"))
        {
            Destroy(other.gameObject);
            Debug.Log("Apple missed!");

            if (gm != null)
                gm.LoseLife();
            else
                Debug.LogError("GameManager not found in scene!");
        }
    }
}