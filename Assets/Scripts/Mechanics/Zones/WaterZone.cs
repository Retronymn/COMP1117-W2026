using UnityEngine;

public class WaterZone : Zone
{
    [Range(0f, 1f)]
    [SerializeField] private float speedModifier = 0.5f;
    // Reducing player's speed by half
    protected override void ApplyZoneEffect(Player player)
    {
        // Change the player's speed modifier value
        player.ApplySpeedModifier(speedModifier);
    }
}
