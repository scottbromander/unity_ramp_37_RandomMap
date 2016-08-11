using UnityEngine;
using System.Collections;

public class Map {

	public Tile[] tiles;
	public int columns;
	public int rows;

	public void NewMap(int width, int height){
		columns = width;
		rows = height;

		tiles = new Tile[columns * rows];

		CreateTiles ();
	}

	private void CreateTiles(){
		var total = tiles.Length;

		for (var i = 0; i < total; i++) {
			var tile = new Tile ();
			tile.id = i;
			tiles [i] = tile;
		}

		FindNeighbors ();
	}

	private void FindNeighbors(){
		for (var r = 0; r < rows; r++) {
			for (var c = 0; c < rows; c++) {
				var tile = tiles [columns * r + c];

				//Bottom
				if (r < rows - 1) {
					tile.AddNeighbor (Sides.Bottom, tiles[columns * (r+1) + c]);
				}

				//Right
				if (c < columns - 1) {
					tile.AddNeighbor (Sides.Right, tiles [columns * r + c + 1]);
				}

				//Left
				if (c > 0) {
					tile.AddNeighbor(Sides.Left, tiles[columns * r + c - 1]);
				}

				//Top
				if (r > 0) {
					tile.AddNeighbor (Sides.Top, tiles [columns * (r - 1) + c]);
				}
			}
		}
	}
}
