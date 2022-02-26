using UnityEngine;

public class PlayerFighter : Fighter
{
    [Header("UI")]
    public PlayerSkillPanel skillPanel;

    void Awake()
    {
        this.stats = new Stats(20, 300, 100, 30, 20);
    }
    
    
    public override void InitTurn()
    {
        this.skillPanel.Show();

        for (int i = 0; i < this.skills.Length; i++)
        {
            this.skillPanel.ConfigureButton(i, this.skills[i].skillName);
        }
    }


    /// ================================================
    /// <summary>
    /// Se llama desde EnemiesPanel.
    /// </summary>
    /// <param name="index"></param>
    public void ExecuteSkill(int index)
    {
       
       this.skillPanel.Hide();

       Skill skill = this.skills[index];

       skill.SetEmitterandReceiver(
           this, this.combatManager.GetOpposingFighter()
       );


       // EXCUTE

       this.combatManager.OnFighterSkill(skill);

    }
}
