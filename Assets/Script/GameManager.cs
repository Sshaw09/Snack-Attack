using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class GameManager : MonoBehaviour
{
    public List<GameObject> collectiblesPrefabs;
    public TextMeshProUGUI scoreText;
    private float spawnRate = 1.5f;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        
    }
    private Vector3 GenerateSpawnPosition()
    {
        float SpawnposX = Random.Range(-4.5f, 4.5f);
        float SpawnposZ = Random.Range(-4.5f, 4.5f);
        Vector3 randomPos = new Vector3(SpawnposX, 3.5f, SpawnposZ);

        return randomPos;
    }
    IEnumerator SpawnTargets()
    {
        while (spawnRate == 1.5f)
        {
            //Every second, a random object from the list gets spawned in game
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, collectiblesPrefabs.Count);
            Instantiate(collectiblesPrefabs[index], GenerateSpawnPosition(), collectiblesPrefabs[index].transform.rotation);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        //Makes the score go up
        score += scoreToAdd;
        Debug.Log("Test");
        
    }
}
