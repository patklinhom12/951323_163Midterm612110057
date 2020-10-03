using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{

    public int itemID;

    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && itemID == 1)
        {
            TimerSystem.timeStart += 20;
            Destroy(this.gameObject, 0.25f);
        }

        if (collision.gameObject.tag == "Player" && itemID == 2)
        {
            TimerSystem.timeStart -= 20;
            Destroy(this.gameObject, 0.25f);
        }
    }

}
