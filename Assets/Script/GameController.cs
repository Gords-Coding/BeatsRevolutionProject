using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public float timeLeft = 3.0f;
    public float gameTime = 0.0f;
    public float screenWidth = Screen.width;
    public float screenHeight = Screen.height;
    public Text startText; // used for showing countdown from 3, 2, 1 
    public GameObject[] spawnSprite;
    GameObject goods;
    public int spawnSpriteCount = 0;

    // the range of X
    public float xMin;
    public float xMax;

    // the range of y
    public float yMin;
    public float yMax;


    void Start()
    {
        InvokeRepeating("loadSprite", 8.0f, 1.0f);
        spawnSpriteCount++;
    }

    void Update()
    {
        //timeLeft -= Time.deltaTime;

        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            startText.enabled = false;
            gameTime += Time.deltaTime;
            //Debug.Log("Playing game");
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }

    void loadSprite()
    {
        // Defines the min and max ranges for x and y
        float coordinX = Random.Range(xMin, xMax);
        float coordinY = Random.Range(yMin, yMax);
        Vector2 pos = new Vector2(coordinX, coordinY);
        // goods now represents the random object within the array
        goods = spawnSprite[Random.Range(0, spawnSprite.Length)];
        // Creates the random object at the random 2D position.
        Instantiate(goods, pos, transform.rotation);
        Debug.Log("Screen Width: " + screenWidth + ", Screen Height: " + screenHeight);
        Debug.Log("Spawn sprite " + spawnSpriteCount + "at (" + coordinX  + ", " + coordinY + ")");
    }
 
}