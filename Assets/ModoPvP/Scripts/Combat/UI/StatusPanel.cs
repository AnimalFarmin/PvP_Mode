using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StatusPanel : MonoBehaviour
{
    public TextMeshProUGUI NamePlayer;
    public TextMeshProUGUI LevelLabel;

    public Slider healthSlider;
    public Image healthSliderbar;
    public TextMeshProUGUI healthLabel;

    public void SetStats(string name, Stats stats)
    {
        this.NamePlayer.text = name;

        this.LevelLabel.text = $"N. {stats.level}";
        this.SetHealth(stats.health, stats.maxHealth);
    }

    public void SetHealth(float health, float maxHealth)
    {
        this.healthLabel.text = $"{Mathf.RoundToInt(health)} / {Mathf.RoundToInt(maxHealth)}";
        float percentage = health / maxHealth;

        this.healthSlider.value = percentage;

        if(percentage < 0.33f)
        {
            this.healthSliderbar.color = Color.red;
        }
    }
}
