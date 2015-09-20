using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
// using System.Data;

/// <summary>
/// The AIEasyPlayer is a type of AIPLayer where it will shoot at random,
/// even if it has found a ship. I.E it is locked in the 'search' state featured
/// in Medium and Hard.
///</summary>

public class AIEasyPlayer : AIPlayer
{

	public AIEasyPlayer(BattleShipsGame controller) : base(controller)
	{

	}

	/// <summary>
	/// GenerateCoordinates generates random shooting coordinates
	/// </summary>
	/// <param name="row">the generated row</param>
	/// <param name="column">the generated column</param>
	
	protected override void GenerateCoords(ref int row, ref int column)
	{
		do 
		{
			SearchCoords(ref row, ref column);
			
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
		//while inside the grid and not a sea tile do the search
	}

	/// <summary>
	/// SearchCoords will randomly generate shots within the grid as long as its not hit that tile already
	/// </summary>
	/// <param name="row">the generated row</param>
	/// <param name="column">the generated column</param>
	private void SearchCoords(ref int row, ref int column)
	{
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}

	protected override void ProcessShot(int row, int col, AttackResult result)
	{
		
	}

}



