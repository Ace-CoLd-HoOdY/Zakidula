using UnityEngine;

public class fire : MonoBehavior{
    [SerializedField] int Damage = 1;

    void Attack(){
        if (colliderBox.isTouching(col) && col.CompareTag("Player"))
    }
}