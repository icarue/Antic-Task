//Class Grid
public class Grid<TCell>
{
	//Constructor
	public Grid<TCell>(){
		var list = [];
	}


	//Add a cell to the list of cells given 2 intergers and a TCell
	void AddCell(int i, int j, TCell cell){
		Grid.Add (cell);
	}

	//Get cell at position i
	TCell GetCell(int i, int j){
		var cell = Grid[i];
		return cell;


	}

	//Delete Cell between positions i and j
	void DeleteCell(int i, int j){
		Grid.Remove(i,j);

	}
	//Delete Cell by finding it's destination and removing it
	void DeleteCell(TCell cell){
		var i = Grid.BinarySearch(Grid,cell);
		Grid.Remove(i,i+1);

	}


}

public class TCell{


}