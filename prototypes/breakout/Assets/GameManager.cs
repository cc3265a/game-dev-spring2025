using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager SharedInstance;
    public TMP_Text livesText;
    public GameObject BrickPrefab;
    public BrickScript[,] bricks;
    int level = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SharedInstance = this;
        NewLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLivesText(string txt)
    {
        print("change called");
        livesText.text = txt;
    }

    public void checkBrickCount()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            if (GameObject.FindGameObjectsWithTag("Brick1").Length == 0)
            {
                if (GameObject.FindGameObjectsWithTag("Brick2").Length == 0)
                {
                    if (GameObject.FindGameObjectsWithTag("Brick3").Length == 0)
                    {
                        if (GameObject.FindGameObjectsWithTag("Brick4").Length == 0)
                        {
                            if (GameObject.FindGameObjectsWithTag("Brick5").Length == 0)
                            {
                                if (level < 5)
                                {
                                    level++;
                                    NewLevel();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    void NewLevel()
    {
        int brickCount = 6 - level;
        bricks = new BrickScript[15, brickCount];


        for (int x = 0; x < 15; x++)
        {
            for (int y = level; y < brickCount; y++)
            {
                // Create a position based on x, y
                Vector3 pos = transform.position;
                float cellWidth = 3.5f;
                float cellHeight = 1.5f;
                float spacing = 0.00f;
                pos.x = pos.x + x * (cellWidth + spacing);
                pos.y = pos.y + y * (cellHeight + spacing);
                GameObject brickObj = Instantiate(BrickPrefab, pos, transform.rotation);

                bricks[x, y] = brickObj.GetComponent<BrickScript>();
                bricks[x, y].x = x;
                bricks[x, y].y = y;


            }
        }
    }
}
