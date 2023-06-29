using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{
    public PlayerAirState(Player _player, PlayerStateMachine _stateMachine, string animBoolName) : base(_player, _stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        // �� �浹
        if (player.IsWallDetected())
            stateMachine.ChangeState(player.wallSlide);

        // �� �浹
        if (player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);

        // �����߿��� �̵�
        if (xInput != 0)
            player.SetVelocitiy(player.moveSpeed * 0.8f * xInput, rb.velocity.y);
    }
}
