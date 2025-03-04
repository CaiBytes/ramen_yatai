using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] RandomOrderGenerator orderGenerator; // Assign this in Inspector
    [SerializeField] float remainingTime; // Default 60 seconds

    public bool gameRunning = true; // Shared state

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            GameOver();
        }

    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameRunning = false;
        orderGenerator.StopOrders();
    }
}