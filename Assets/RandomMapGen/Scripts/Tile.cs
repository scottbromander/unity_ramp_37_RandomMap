using UnityEngine;
using System.Collections;

public enum Sides{
	Bottom,
	Right,
	Left,
	Top
}

public class Tile {
	public int id = 0;
	public Tile[] neighbors = new Tile[4];

	public void AddNeighbor	(Sides side, Tile tile){
		neighbors [(int)side] = tile;
	}
}
