using UnityEngine;

public class box : MonoBehaviour
{

    void Start()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }   
    }
}
