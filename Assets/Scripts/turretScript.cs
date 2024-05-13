using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class turretScript : MonoBehaviour
{

    public float Range;
    public Transform Target;
    Vector2 Direction;

    public GameObject Body;
    public GameObject Light;
    public GameObject Barrel;
    public GameObject Bullet;

    public float maxRot;
    public float minRot;

    public float ifRotationIs;
    public float rotateByThisMuch;

    public float FireRate;
    float ttf = 0;
    public float Force;

    public Transform ShootPoint;

    bool Detected = false;

    void Update()
    {
        Vector2 position = Target.position;
        Direction = position - (Vector2)transform.position;
        Direction.Normalize();
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, Direction, Range, 9);

        Debug.DrawRay(transform.position, Direction.normalized * Range, Color.green);

        if (raycast)
        {   
            if(raycast.collider.gameObject.tag == "Player")
            {
                if(Detected == false)
                {
                    Detected = true;
                    Light.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }

            
        }
        else
        {
            if (Detected == true)
            {
                Detected = false;
                Light.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
        if (Detected)
        {
            Barrel.transform.up = -Direction;

            Vector3 currentRotation = Barrel.transform.localEulerAngles;

            
            if(currentRotation.z > ifRotationIs) {
                currentRotation.z -= rotateByThisMuch;
            }
            currentRotation.z = Mathf.Clamp(currentRotation.z, minRot, maxRot);
            Barrel.transform.rotation = Quaternion.Euler(currentRotation);



            if (Time.time > ttf)
            {
                ttf = Time.time + 1 / FireRate;
                Fire();
            }
        }
    }

    void Fire()
    {
        Vector3 currentRotation = Barrel.transform.localEulerAngles;
        if (currentRotation.z > ifRotationIs)
        {
            currentRotation.z -= rotateByThisMuch;
        }
        currentRotation.z = Mathf.Clamp(currentRotation.z, minRot, maxRot);
        if (Mathf.Abs(currentRotation.z) < 90f)
        {
            GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
            BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
             
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
