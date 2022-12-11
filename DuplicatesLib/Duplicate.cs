namespace DuplicatesLib
{
    public class Duplicate
    {
        public static bool Present(int[] array)
        {
            bool res = false;

            for(int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        res = true;

            return res;
        }
    }
}