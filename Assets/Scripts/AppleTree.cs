using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnRate = 1.5f;
    public float xRange = 8f;
    public float ySpawn = 10f;

    private bool gameOver = false;

    void Start()
    {
        InvokeRepeating(nameof(DropApple), 1f, spawnRate);
    }

    void DropApple()
    {
        if (gameOver) return;

        Vector3 pos = new Vector3(
            Random.Range(-xRange, xRange),
            ySpawn,
            0
        );

        Instantiate(applePrefab, pos, Quaternion.identity);
    }

    public void StopSpawning()
    {
        gameOver = true;
        CancelInvoke(nameof(DropApple));
    }
}