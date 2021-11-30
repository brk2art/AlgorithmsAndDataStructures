namespace AlgorithmsAndDataStructuresExercises
{
    class MergeSortAlgorithm
    {
        public static void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (int j = 0; j < num; j++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public static void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid+1), right);
            }
        }
    }
}
