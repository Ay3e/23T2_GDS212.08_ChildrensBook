using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowFishDialogue : MonoBehaviour
{
    [SerializeField] private GameObject testingtext;

    private void OnTriggerEnter(Collider other)
    {
        testingtext.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        testingtext.SetActive(false);
    }
}
