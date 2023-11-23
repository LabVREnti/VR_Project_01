using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    OmniMovementComponent MovementComponent;
    CharacterController m_CharacterController;

    void Start()
    {
        MovementComponent = GetComponent<OmniMovementComponent>();
        m_CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UseOmniInputToMovePlayer();
    }

    void UseOmniInputToMovePlayer()
    {
        if (MovementComponent.omniFound)
            MovementComponent.GetOmniInputForCharacterMovement();
        else if (MovementComponent.developerMode)
            MovementComponent.DeveloperModeUpdate();


        if (MovementComponent.GetForwardMovement() != Vector3.zero)
            m_CharacterController.Move(MovementComponent.GetForwardMovement());
        if (MovementComponent.GetStrafeMovement() != Vector3.zero)
            m_CharacterController.Move(MovementComponent.GetStrafeMovement());
    }
}
