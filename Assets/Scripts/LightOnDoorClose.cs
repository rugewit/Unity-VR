using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnDoorClose : MonoBehaviour
{
    public GameObject enterDoor;
    public GameObject trapDoor;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            {
            enterDoor.SetActive(true);
            trapDoor.SetActive(true);
            }
    }
}
