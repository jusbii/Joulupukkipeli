using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the target moves
    public float changeDirectionInterval = 2f; // Time interval for changing direction

    private Vector3 randomDirection;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeDirectionRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);
    }
    IEnumerator ChangeDirectionRoutine()
    {
        while (true)
        {
            // Random direction in 2D
            randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;

            // Wait for the specified interval before changing direction again
            yield return new WaitForSeconds(changeDirectionInterval);
        }
    }
}
