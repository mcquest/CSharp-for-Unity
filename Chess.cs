// Charles Farris
// Chess.cs for Unity
// Attach script to empty object and add piece objects to public variables
// -king, queen, rook, knight, bishop, pawn 

// Built in classes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

// Class-Object 
public class HeightTracker : MonoBehaviour 
{
	// Global Variables

	// Black Team list
	// = [[king, pos], [queen, pos], [rook, pos], [knight, pos], [bishop, pos], [pawn, pos]x8

	//White Team list
	// = [[king, pos], [queen, pos], [rook, pos], [knight, pos], [bishop, pos], [pawn, pos]x8

	// Pieces
	public Transform king;
	public Transform queen;
	public Transform rook;
	public Transform knight;
	public Transform bishop;
	public Transform pawn;

	// Board
		// List<List<Vector3>> = new list of 8 list elements
		// for i 1-8, for j 1-8 set Vector3 pos for 64 squares
		//= Vector3(letter, 0, i* cell distance)

	// -- Gameplay Booleans--
	// blackMove (true/false)
	// inCheck

	// Start is called before the first frame
	void Start ()
    {
		//Draw Board
		// Set, tag, and color pieces
		// Update board multi dim list
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

	// Draw Board
		// for letter 1 - 8
			// for numbers 1-2, 7-8
				// Use Board[letter][number] to instantiate piece at Vector3 pos

	// Notation to position function

	// Highlight Piece

	// On Click

		// Black Piece if blackMove == true then highlight piece and valid moves		
		// White Piece if blackMove == false then highlight piece and valid moves

		// Grid Square if square in movesList
			// then movePiece (piece, square)
				// Capture piece (square)
				// update list
				// record move

	// ValidMoves(piece)
		// if king

		// if queen

		// if rook

		// if knight

		// if bishop

		// if pawn

	// Checkmate() 
		// if blackMove then king = BlackTeam[1] (obj, pos)
		// if not blackMove then king = WhiteTeam[1] (obj, pos)
		// if inCheck && ValidMoves(king) == null
			// if blackMove White wins
			// else Black wins

}
