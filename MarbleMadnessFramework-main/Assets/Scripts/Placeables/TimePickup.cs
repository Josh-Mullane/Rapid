using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }
   

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player Ball")
        {
            LevelTimer.Instance.remainingTime += 10;
            Destroy(this.gameObject);
        }

    }
}
