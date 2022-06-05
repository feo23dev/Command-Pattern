using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command // our actual command class 
{
    public abstract void Execute(Animator anim);
}

public class PerformJump: Command 
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isJumping");
    }
}

public class DoNothing: Command
{
    public override void Execute(Animator anim)
    {
        throw new System.NotImplementedException();
    }
}

public class PerformKick: Command 
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isKicking");
    }
}

public class PerformPunch: Command 
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isPunching");
    }
}






