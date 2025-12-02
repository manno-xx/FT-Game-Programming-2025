using UnityEngine;

public class CollisionCheck : MonoBehaviour
{   
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log($"Oops I hit {other.transform.name}");
        Time.timeScale = .2f;
        
        SendMessage("DisableInput");
    }
}
