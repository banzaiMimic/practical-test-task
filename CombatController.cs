using System.Collections;

public class CombatController {

  private BaseCharacter character;
  private Coroutine debuffCoroutine;

  public CombatController( BaseCharacter character ) {
    character = character;
  }

  public void ApplyDamage( float dmg ) {
    character.TakeDamage( dmg );
  }

  public void ApplyDebuff( float dmg, float time ) {
    debuffCoroutine = character.StartCoroutine( Debuff( dmg, time ) );
  }

  private IEnumerator Debuff( float dmg, float time ) {
    float dmgTick = dmg / time;
    float dmgTaken = 0;
    while (dmgTaken < dmg) {
      ApplyDamage( dmgTick );
      dmgTaken += dmgTick;
      if ( character.isDead ) {
        character.StopCoroutine( debuffCoroutine );
      }
      yield return new WaitForSeconds( 1f );
    }
  }

}