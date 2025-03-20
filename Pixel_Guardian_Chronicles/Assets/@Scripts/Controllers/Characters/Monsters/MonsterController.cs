using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class MonsterController : CreatureController
{
   

    #region Fields
    [SerializeField] float speed = 2f;
    public Rigidbody2D target;

    Rigidbody2D rb;

    #endregion

    #region Properties
    #endregion

    #region Methods
    public override bool Init()
    {
        if (base.Init() == false)
        {
            Debug.Log($"{nameof(MonsterController)} / {nameof(Init)} Fail");
            return false;
        }

        return true;
    }

    public override void CharacterAttack()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterDamaged()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterDeath()
    {
        throw new System.NotImplementedException();
    }

    public override void CharacterMove()
    {
        //몬스터가 캐릭터를 쫓아가게
        Vector2 dir = target.position - rb.position;
        Vector2 movement = dir.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
        rb.velocity = Vector2.zero;
    }
    #endregion

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CharacterMove();
    }
}
