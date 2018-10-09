using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public static float rotateSpeed = 5;

	// Use this for initialization
	void Start ()
    {
        EnemyManager.instance.enemyCount++;

	}

    private void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    private void OnMouseDown()
    {
        StartCoroutine(FadeMe());
    }

    IEnumerator FadeMe()
    {
        yield return new WaitForSeconds(2);

        for (float f = 1f; f >= 0; f -= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = f;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
        yield return new WaitForSeconds(1);
        EnemyManager.instance.enemyCount--;
        //EnemyManager.instance.SpawnEnemy++;
        GameManager.instance.scoreTotal+= 100;
        Destroy(this.gameObject);
    }
}
