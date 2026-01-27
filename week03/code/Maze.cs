/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // Get the current position's valid movements
        // Format: [left, right, up, down]
        var validMoves = _mazeMap[(_currX, _currY)];
        
        // Check if left (index 0) is valid
        if (validMoves[0])
        {
            _currX--; // Move left means decrease x
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // Get the current position's valid movements
        // Format: [left, right, up, down]
        var validMoves = _mazeMap[(_currX, _currY)];
        
        // Check if right (index 1) is valid
        if (validMoves[1])
        {
            _currX++; // Move right means increase x
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // Get the current position's valid movements
        // Format: [left, right, up, down]
        var validMoves = _mazeMap[(_currX, _currY)];
        
        // Check if up (index 2) is valid
        if (validMoves[2])
        {
            _currY--; // Move up means decrease y
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // Get the current position's valid movements
        // Format: [left, right, up, down]
        var validMoves = _mazeMap[(_currX, _currY)];
        
        // Check if down (index 3) is valid
        if (validMoves[3])
        {
            _currY++; // Move down means increase y
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}