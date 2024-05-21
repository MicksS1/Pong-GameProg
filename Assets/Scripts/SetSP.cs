using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSP : MonoBehaviour
{
    public GameObject SP;

    public void ActivateSP()
    {
        SP.SetActive(true);
    }

    public void DeactiveSP()
    {
        SP.SetActive(false);
    }
}
