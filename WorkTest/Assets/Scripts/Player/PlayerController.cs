using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private PlayerMovement playerMovement = null;
    [SerializeField] private PlayerAnimationController playerAnimationController = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        playerMovement.Move(input);

        SetPlayerAnimations(input);
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS
    private void SetPlayerAnimations(float input)
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerAnimationController.FlipSprite(true);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerAnimationController.FlipSprite(false);
        }

        playerAnimationController.SetAnimation(input);
    }
    #endregion
}
