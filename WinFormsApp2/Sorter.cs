namespace Task_5_2
{
    public class Sorter
    {
        private int[] _numbers;

        // Constructor to initialize the array
        public Sorter(int[] numbers)
        {
            _numbers = numbers;
        }

        // Method to sort the array in descending order
        public void SortDescending()
        {
            for (int i = 0; i < _numbers.Length - 1; i++)
            {
                for (int j = 0; j < _numbers.Length - i - 1; j++)
                {
                    // Swap if the current element is smaller than the next element
                    if (_numbers[j] < _numbers[j + 1])
                    {
                        int temp = _numbers[j];
                        _numbers[j] = _numbers[j + 1];
                        _numbers[j + 1] = temp;
                    }
                }
            }
        }

        // Method to get the sorted array
        public int[] GetSortedArray()
        {
            return _numbers;
        }

    }
}
