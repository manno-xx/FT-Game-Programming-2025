using UnityEngine;
using Random = UnityEngine.Random;

public class Pipes : MonoBehaviour
{
    // reference to the pipes
    [SerializeField] private Transform topPipe;
    [SerializeField] private Transform bottomPipe;
 
    // move the pipes per second
    [SerializeField] private float moveSpeed;
    
    // range of pipe movement
    [SerializeField] private float moveRange;

    private void Awake()
    {
        MovePipes();
    }
    
    private void MovePipes()
    {
        var randomOffset = Random.Range(-moveRange, moveRange);
        // move pipes up or down
        topPipe.Translate(Vector3.up * randomOffset);
        bottomPipe.Translate(Vector3.up * randomOffset);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);
    }
}
