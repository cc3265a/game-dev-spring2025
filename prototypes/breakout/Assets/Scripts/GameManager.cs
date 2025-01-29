using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager SharedInstance;
    public TMP_Text livesText;
    public GameObject BrickPrefab;
    public GameObject Brick2Prefab;

    public BrickScript[,] bricks;
    int level = 0;

    public TMP_Text PointsText;
    int points = 0;

    Vector3 SpawnPos = new Vector3(0, 10, 0);

    public int Lives = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SharedInstance = this;
        NewLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Brick");
            foreach (GameObject go in gos)
                Destroy(go);

            level++;
            print(level);
            NewLevel();
        }

    }

    public void changeLivesText(string txt)
    {
        //print("change called");
        livesText.text = txt;
    }
    public void PointsGet(int addPoints)
    {
        points = points + addPoints; 
        PointsText.text = points.ToString();
    }

    public void checkBrickCount()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            if (level < 5)
            {
                level++;
                NewLevel();
            }
        }
    }

    void NewLevel()
    {
        //BallScript.SharedInstance2.resetBallPos();

        Lives++;
        PointsGet(level*2);
        if (level > 5)
        {
            level = 0;
        }
        int brickCount = 6 - 1;
        print("brick count = "+ brickCount);
        bricks = new BrickScript[15, brickCount];


        for (int x = 0; x < 15; x++)
        {
            for (int y = 0; y < brickCount; y++)
            {
                GameObject useBrick = BrickPrefab;

                // Create a position based on x, y
                Vector3 pos = transform.position;
                float cellWidth = 3.5f;
                float cellHeight = 1.5f;
                float spacing = 0.00f;
                pos.x = pos.x + x * (cellWidth + spacing);
                pos.y = pos.y + y * (cellHeight + spacing);
                float randBrick = Random.Range(0f, 10f);
                if (randBrick <= level)
                {
                    print("speed brick made at " + x + " " + y);
                    useBrick = Brick2Prefab;
                }
                GameObject brickObj = Instantiate(useBrick, pos, transform.rotation);

                bricks[x, y] = brickObj.GetComponent<BrickScript>();
                bricks[x, y].x = x;
                bricks[x, y].y = y;


            }
        }
    }

    public void GetPaddlePos(Vector3 paddlePos)
    {
        SpawnPos = paddlePos;
    }
    public float getSpawnPos()
    {
        return SpawnPos.x;
    }

    public int getLives()
    {
        return Lives;
    }

    public void loseLife()
    {
        Lives--;
    }
}
