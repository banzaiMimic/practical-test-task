using UnityEngine;

public class BaseCharacter {

  [HideInInspector]
  public float health;

  [SerializeField]
  private float initHealth;

  [SerializeField]
  private float hpRegeneratePerSecond;

  [HideInInspector]
  public bool isDead;

  private void Init() {

  }

  private void Start() {

  }

  private void LateUpdate() {

  }

  private void Die() {
    
  }
}