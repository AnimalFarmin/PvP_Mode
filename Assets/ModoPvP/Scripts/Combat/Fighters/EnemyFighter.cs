using UnityEngine;
using System.Collections;

public class EnemyFighter : Fighter
{
    
    void Awake()
    {
        this.stats = new Stats(20, 200, 40, 30, 60);
    }
    
    public override void InitTurn()
    {
        StartCoroutine(this.IA());
    }
    IEnumerator IA()
    {
        yield return new WaitForSeconds(1f);

        Skill skill = this.skills[Random.Range(0, this.skills.Length)];

        skill.SetEmitterandReceiver(
            this, this.combatManager.GetOpposingFighter()
        );

       this.combatManager.OnFighterSkill(skill);
    }

}
