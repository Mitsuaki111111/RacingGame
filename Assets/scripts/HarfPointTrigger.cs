using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harf : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HarfLapTrig;

    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        HarfLapTrig.SetActive(false);
    }
}
