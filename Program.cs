using _035_room_coordinates;

Coordinate[] coordinates = new Coordinate[9]; 

CreateRoomCoordinates();

// Create a 3x3 grid of coordinates
void CreateRoomCoordinates()
{
    for (int i = 0; i < 3; i++) // row
    {
        Console.WriteLine();
        for (int j = 0; j < 3; j++)
        {
            Coordinate coordinate = new Coordinate(i, j);
            coordinates[i] = coordinate;

            Console.Write($"[{coordinates[i].Row}, {coordinates[i].Column}]");

            IsAdjacent(coordinates);
        }
    }
}

// Check room for adjacency
bool IsAdjacent(Coordinate[] coordinates)
{
    foreach (var item in coordinates)
    {
        if (item.Row == 0 && item.Column != 0) Console.WriteLine("Adjacent.");
    }
    
    return false;
}