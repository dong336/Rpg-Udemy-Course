using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvent : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = GetComponentInParent<Player>();
    }

    public void AnimationTrigger()
    {
        player.AttackOver();
    }

    void Update()
    {
        
    }
}
