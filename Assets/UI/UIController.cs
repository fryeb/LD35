using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

    public Transform hero_bar;
    public Player hero;

    public Transform boss_bar;
    public Boss boss;

	// Update is called once per frame
	void Update () {
        if (hero)
        {
            Vector3 newHeroScale = new Vector3(hero.health / hero.maxHealth, 1f, 1f);
            hero_bar.localScale = newHeroScale;
        }

        if (boss)
        {
            Vector3 newBossScale = new Vector3(boss.health / boss.maxHealth, 1f, 1f);
            boss_bar.localScale = newBossScale;
        }
	}
}
