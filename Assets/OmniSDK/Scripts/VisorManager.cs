using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VisorManager : MonoBehaviour
{
    [SerializeField] bool plataforma;
    [SerializeField] GameObject locomotionSystem;
    [SerializeField] GameObject XROrigin;

    private void Update()
    {
        if ( plataforma )
        {
            locomotionSystem.SetActive( false );
            XROrigin.GetComponent<OmniMovementComponent>().enabled = true;
        }
        else if(!plataforma)
        {
            locomotionSystem.SetActive(true);
            XROrigin.GetComponent<OmniMovementComponent>().enabled = false;

        }
        else
        {
            Debug.Log("ALgo ha salido mal :(");
        }
    }
}
