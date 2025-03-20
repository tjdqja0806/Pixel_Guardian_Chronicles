using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class PlayerController : CreatureController
{
    #region Fields
    [SerializeField] float moveSpeed = 3f;
    #endregion

    #region Properties
    #endregion

    #region Methods
    public override bool Init()
    {
        if (base.Init() == false)
        {
            Debug.Log($"{nameof(PlayerController)} / {nameof(Init)} Fail");
            return false;
        }

        ObjectType = ObjectType.Player;

        return true;
    }



    public override void CharacterAttack()
    {

    }

    public override void CharacterDamaged()
    {

    }

    public override void CharacterDeath()
    {

    }

    public override void CharacterMove()
    {
        //�Է°�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //����
        Vector3 direction = new Vector3(h, v).normalized;

        //������
        transform.position += direction * moveSpeed * Time.deltaTime;

    }

    public void MoveInput()
    {

    }

    public virtual void DoSignatureMove()
    {

    }
    #endregion

    private void Update()
    {
        CharacterMove();
    }
}
