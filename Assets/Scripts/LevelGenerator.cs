using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject treePrefab;
    // private int GROUND = 0;
    private int TREE = 1;

    public int ROWS = 25;
    public int COLS = 25;
    public int MAX_PATH_SIZE = 25;
    public int SQUARE_SIZE = 8;
    // private int MAX_PATH_SIZE = 400;

    private int[,] maze;
    // Start is called before the first frame update

    private int[,] generateInitialMaze (int[,] maze) {
      // 2560
      for (int x = 0; x < ROWS; x++) {
        for (int y = 0; y < COLS; y++) {
          maze[x,y] = TREE;
        }
      }
      return maze;
    }

    private int[,] setCenter (int[,] maze) {
      int SIZE = 10;
      int rowCenterStart = ROWS/2 - 5;
      int colCenterStart = COLS/2 - 5;

      for(int x = rowCenterStart; x < rowCenterStart + SIZE; x++) {
        for (int y = colCenterStart; y < colCenterStart + SIZE; y++) {
          maze[x,y] = 0;
        }
      }

      return maze;
    }

    private int[,] generateFloor (int[,] maze) {
      int rowCenterStart = ROWS/2 - 5;
      int colCenterStart = COLS/2 - 5;

      int xStart = Random.Range(0, 10);
      int yStart = Random.Range(0, 10);

      int currentCount = 0;

      xStart = rowCenterStart + xStart;
      yStart = colCenterStart + yStart;

      maze[yStart, xStart] = 0;
      int xVal = xStart;
      int yVal = yStart;

      while (currentCount < MAX_PATH_SIZE) {

        if (Random.Range(1,10) >= 5) {
          xVal += Random.Range(-1, 1);
        } else {
          yVal += Random.Range(-1, 1);
        }

        maze[xVal, yVal] = 0;
        currentCount++;
      }
      return maze;
    }

    private void drawPrefabs (int[,] maze) {

      for (int y = 0; y < COLS; y++) {
        int nextPosX = -1 * (ROWS / 2);
        int nextPosY = (COLS / 2) - y;

        for (int x = 0; x < ROWS; x ++) {
          if (maze[x,y] == 1) {
            Instantiate(treePrefab, new Vector3(nextPosX, nextPosY, 0), Quaternion.identity);

          }
          nextPosX = -1 * (ROWS / 2) + x;
        }
      }
    }

    void Start()
    {
      maze = new int [ROWS,COLS];
      maze = generateInitialMaze(maze);
      maze = setCenter(maze);
      maze = generateFloor(maze);
      maze = generateFloor(maze);
      maze = generateFloor(maze);
      maze = generateFloor(maze);
      maze = generateFloor(maze);
      drawPrefabs(maze);
      // Debug.Log(maze[2,3]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
