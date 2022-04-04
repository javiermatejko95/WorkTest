using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private Animator anim = null;
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS

    #endregion

    #region PUBLIC_METHODS
    public void SetAnimation(float movingAxis)
    {
        if(movingAxis != 0f)
        {
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    public void FlipSprite(bool state)
    {
        spriteRenderer.flipX = state;
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
