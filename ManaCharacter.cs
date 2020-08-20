using UnityEngine;

public class ManaCharacter : BaseCharacter {

  [HideInInspector]
  public float mana;

  [SerializeField]
  private float initMana;

  [SerializeField]
  private float manaRegeneratePerSecond;

  public override Start() {
    base.Start();
  }

}