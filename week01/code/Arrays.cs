public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array of doubles with the given length.
        // This array will store the multiples of the number.
        double[] result = new double[length];

        // Step 2: Loop from index 0 up to length - 1.
        // Each index represents which multiple we are calculating.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple.
            // The first multiple should be number * 1, so we use (i + 1).
            result[i] = number * (i + 1);
        }

        // Step 4: Return the completed array of multiples.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// For example, if the data is List<int>{1,2,3,4,5,6,7,8,9} and amount is 3,
    /// the list becomes List<int>{7,8,9,1,2,3,4,5,6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine how many elements will be moved from the end to the front.
        // The amount is guaranteed to be between 1 and data.Count.
        int count = data.Count;

        // Step 2: Use GetRange to take the last 'amount' elements.
        // These elements will be moved to the front of the list.
        List<int> rightPart = data.GetRange(count - amount, amount);

        // Step 3: Remove the last 'amount' elements from the original list.
        data.RemoveRange(count - amount, amount);

        // Step 4: Insert the saved elements at the beginning of the list.
        data.InsertRange(0, rightPart);

        // Step 5: The list is now rotated to the right.
        // No return value is needed because the list is modified in place.
    }
}
