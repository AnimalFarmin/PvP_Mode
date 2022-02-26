public class Stats
{
    public float health;
    public float maxHealth;

    public int level;
    public float attack;
    public float deffense;
    public float spirit;

    public Stats(int level, float maxhealth, float attack, float deffense, float spirit)
    {
        this.level = level;

        this.maxHealth = maxhealth;
        this.attack = attack;
        this.deffense = deffense;
        this.spirit = spirit;
        this.health = maxhealth;
    }
        public Stats clone()
    {
        return new Stats(this.level, this.maxHealth, this.attack, this.deffense, this.spirit);
    }

}
