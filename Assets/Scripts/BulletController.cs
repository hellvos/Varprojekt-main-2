using UnityEngine;

public class BulletController : MonoBehaviour
{
  [SerializeField]
  float speed = 10000f;

  void Start()
  {
    Destroy(gameObject, 5);
    GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
  }

  void Update()
  {
     //transform.Translate(Vector3.forward * speed * Time.deltaTime);
  }

   void OnTriggerEnter(Collider collision)
    {
        print("test");
        if (!collision.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }   
    }
}
