using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrderGenerator : MonoBehaviour
{

    public string[] broths = { "Shoyu", "Pork" };
    public string[] toppings = { "Green Onion", "Soft-boiled Egg", "Fish Cake", "Pork Belly" };
    public string currentOrder = "";
    List<string> orderList = new List<string>();

    [SerializeField] Timer timer; // Reference to Timer script

    private void Start()
    {
        StartCoroutine(OrderRoutine());
    }

    private IEnumerator OrderRoutine()
    {
        // Generate the first order within the first 5 seconds
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        GenerateOrder();

        while (timer.gameRunning)
        {
            Debug.Log(timer.gameRunning);
            // Wait for the next 20-second block
            yield return new WaitForSeconds(20f);

            // Generate a random number of orders (1 to 3) within this block
            int ordersToGenerate = Random.Range(1, 4);

            for (int i = 0; i < ordersToGenerate; i++)
            {
                float randomDelay = Random.Range(2f, 6f); // Random delay before each order
                yield return new WaitForSeconds(randomDelay);
                GenerateOrder();
            }
        }
    }

    public void GenerateOrder()
    {
        string noodles = "Noodles";
        string broth = broths[UnityEngine.Random.Range(0, broths.Length)];
        List<string> ingredients = new List<string> { noodles, broth };

        foreach (string ingredient in toppings)
        {
            if (UnityEngine.Random.value > 0.5f)
            {
                ingredients.Add(ingredient);
            }
        }

        //Debug.Log("New order: " + string.Join(", ", ingredients));
        currentOrder = string.Join(", ", ingredients);
        orderList.Add(currentOrder);
    }

    public void StopOrders()
    {
        Debug.Log(orderList);
        StopAllCoroutines();
    }
}







