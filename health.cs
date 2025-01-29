using UnityEngine;

public class health : MonoBehavior{
    public int max_health = 4;
    public int current_health;
    public int healing = 1;

    void Start(){
        current_health = max_health;
    }

    public void Damage(int damage){
        if (current_health != 0){
            current_health -= damage;
        }
    }

    void Healing(){
            if (current_health != 0){
            current_health += healing;
        }
    }
}