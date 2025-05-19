using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehavious : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
public class projectile : MonoBehaviour
{
    private float speed;

        public void setspeed(float newSpeed)
        {
            speed = newSpeed;
        }
        
        public void Fire()
        {
            if (speed > 0)
            {
                Debug.Log("Firing projectile at speed" + speed);
            }

            else
            {
                Debug.Log("Cannot fire: speed too low");
                AutoFire();
            }
        }
        public void AutoFire()
        {
            speed = 100f;
            Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
        }   
}