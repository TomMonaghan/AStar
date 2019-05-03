using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int gridX; //X Position in the node Array
    public int gridY; //Y Position in the node Array

    public bool IsWall; // Tells the program if the node is being obstructed
    public Vector3 Position; // The world position of the node

    public Node Parent; //For the AStar algorithm, will store what node it previously came from so it can trace the shortest path

    public int gCost;// The cost of moving to the next square
    public int hCost; //The distance to the goal from this node
    
    public int Fcost
    {
        get { return gCost + hCost; } //Quick get function to add G cost and H cost, and since we'll never need to edit Fcost, we don't need a set function
    }

    public Node(bool a_IsWall, Vector3 a_Pos, int a_gridX, int a_gridY) //Constructor
    {
        IsWall = a_IsWall; //tells the program if this node is being obstructed
        Position = a_Pos; //the world position of the node
        gridX = a_gridX; //X Position in the Node Array
        gridY = a_gridY; //Y Position in the Node Array
    }
}
