using UnityEngine;
using System.Collections;

public class Rook : Chessman {	
	public override bool[,] IsMovePossible()
	{
		bool[,] r = new bool[8,8];
		bool HasMoved = false;
		Chessman c,c2,c3,c4;
		int i; 
		//right
		i = CurrentX;
		while (true) 
		{
			i++;
			if (i >= 8)
				break;
			c = BoardManager.Instance.Chessmans[i, CurrentY];
			if (c== null)
				r[i , CurrentY] = true;
			else
			{
				if(c.isWhite != isWhite)
				{
					r[i , CurrentY] = true;
				}
				break;
			}


		}
		//left
		i = CurrentX;
		while (true) 
		{
			i--;
			if (i < 0)
				break;
			c = BoardManager.Instance.Chessmans[i, CurrentY];
			if (c== null)
				r[i , CurrentY] = true;
			else
			{
				if(c.isWhite != isWhite)
				{
					r[i , CurrentY] = true;
				}
				break;
			}
		}
		//up
		i = CurrentY;
		while (true) 
		{
			i++;
			if (i >= 8)
				break;
			c = BoardManager.Instance.Chessmans[CurrentX, i];
			if (c== null)
				r[CurrentX , i] = true;
			else
			{
				if(c.isWhite != isWhite)
				{
					r[CurrentX , i] = true;
				}
				break;
			}
			
			
		}
		i = CurrentY;
		while (true) 
		{
			i--;
			if (i < 0)
				break;
			c = BoardManager.Instance.Chessmans[CurrentX, i];
			if (c== null)
				r[CurrentX , i] = true;
			else
			{
				if(c.isWhite != isWhite)
				{
					r[CurrentX , i] = true;
				}
				break;
			}
		}
		//Castle
		//white left
		if (!HasMoved && isWhite && CurrentX == 7) 
		{
			c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY];
			c2 = BoardManager.Instance.Chessmans[CurrentX - 2 , CurrentY];
			c3 = BoardManager.Instance.Chessmans[CurrentX - 3, CurrentY];
			c4 = BoardManager.Instance.Chessmans[CurrentX - 4, CurrentY];
			if (c == null && c2 == null && c3 == null && c4.GetType() == typeof(King))
			{
				r[CurrentX - 4, CurrentY] = true;
			}
		}

		return r;
	}
}
