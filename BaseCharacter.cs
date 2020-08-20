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

  private CombatController combatController;

  private void Init() {

  }

  private void Start() {
    combatController = new CombatController( this );
  }

  private void LateUpdate() {

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