using UnityEngine;

public class BaseCharacter : MonoBehabiour {

  [HideInInspector]
  protected float health = 100;

  [SerializeField]
  protected float initHealth = 100;

  [SerializeField]
  protected float hpRegeneratePerSecond = 0;

  [HideInInspector]
  public bool isDead = false;

  protected CombatController combatController;

  public virtual Start() {
    combatController = new CombatController( this );
  }

  public void TakeDamage( float dmg ) {
    health -= dmg;
    if ( health <= 0 ) {
      Die();
    }
  }

  private void Die() {
    isDead = true;
  }
}