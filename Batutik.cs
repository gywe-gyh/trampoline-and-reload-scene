using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batutik : MonoBehaviour
{ public float jumppower = 3.5f;
    private void OnTriggerEnter(Collider other)
    {
        Jump fpm;
        bool HasFPM = other.TryGetComponent<Jump>(out fpm);
        if (HasFPM)
        {
            fpm.jumpStrength *= jumppower;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Jump fpm;
        bool HadFPM = other.TryGetComponent<Jump>(out fpm);
        if (HadFPM)
        {
            fpm.jumpStrength /= jumppower;

        }
        
    }
    
}

