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

}
