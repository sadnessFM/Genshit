namespace Genshit;

public class Sorts
{
    /*
     в каждой сортировке первые три строки нужны для работы сортировки
     где куча while - сама работа сортировки
     она рекурсивна до тех пор пока последние два ифа не будут провалены на чем и заканчивается сортировка которая
     возвращает список персонажей в отсортированном виде
     по сути это одна и та же сортировка только с разными ответами ибо в while используются разные поля Character
     */

    public static List<Character> SortByWinCount(List<Character> array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Character pivot = array[leftIndex];
            
            while (i <= j)
            {
                while (array[i].WinCount < pivot.WinCount) i++;

                while (array[j].WinCount > pivot.WinCount) j--;

                if (i > j) continue;
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }

            if (leftIndex < j)
                SortByWinCount(array, leftIndex, j);
            if (i < rightIndex)
                SortByWinCount(array, i, rightIndex);
            return array;
        }

        public static List<Character> SortByName(List<Character> array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Character pivot = array[leftIndex];
            
            while (i <= j)
            {
                while (string.CompareOrdinal(array[i].Name, pivot.Name) > 0) i++;

                while (string.CompareOrdinal(array[j].Name, pivot.Name) < 0) j--;

                if (i > j) continue;
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }

            if (leftIndex < j)
                SortByName(array, leftIndex, j);
            if (i < rightIndex)
                SortByName(array, i, rightIndex);
            return array;
        }

        public static List<Character> SortById(List<Character> array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Character pivot = array[leftIndex];
            
            while (i <= j)
            {
                while (array[i].Id < pivot.Id) i++;

                while (array[j].Id > pivot.Id) j--;

                if (i > j) continue;
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }

            if (leftIndex < j)
                SortById(array, leftIndex, j);
            if (i < rightIndex)
                SortById(array, i, rightIndex);
            return array;
        }

        public static List<Character> SortByWinRatio(List<Character> array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Character pivot = array[leftIndex];
            
            while (i <= j)
            {
                while (array[i].GetWinRate() < pivot.GetWinRate()) i++;

                while (array[j].GetWinRate() > pivot.GetWinRate()) j--;

                if (i > j) continue;
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }

            if (leftIndex < j)
                SortByWinRatio(array, leftIndex, j);
            if (i < rightIndex)
                SortByWinRatio(array, i, rightIndex);
            return array;
        }
}