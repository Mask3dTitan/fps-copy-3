using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            print("hit"+collision.gameObject.name + "!");
            CreateBulletImpactEffect(collision);
            Destroy(gameObject);




        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            print("hit a wall");
            CreateBulletImpactEffect(collision);
            Destroy(gameObject);
        }
    }
    void CreateBulletImpactEffect(Collision objectWeHit)
    {
        //create bullet impact effect
        ContactPoint contact = objectWeHit.contacts[0]; 

        GameObject hole = Instantiate(
            GlobalReferences.Instance.bulletImpactEffectPrefab,
            contact.point,
            Quaternion.LookRotation(contact.normal));
        
        hole.transform.SetParent(objectWeHit.transform);


    }
}
