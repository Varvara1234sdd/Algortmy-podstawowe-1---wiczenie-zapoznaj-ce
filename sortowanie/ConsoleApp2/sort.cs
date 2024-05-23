namespace SortowaniePrzezWybieranie
{
    public class Sortowanie
    {
        // Metoda sortująca tablicę malejąco przez wybieranie
        public void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            // Iteracja po elementach tablicy
            for (int i = 0; i < n - 1; i++)
            {
                // Znalezienie indeksu maksymalnej wartości w nieposortowanej części tablicy
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] > tablica[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Zamiana miejscami elementu na pozycji i z maksymalnym elementem
                int temp = tablica[i];
                tablica[i] = tablica[maxIndex];
                tablica[maxIndex] = temp;
            }
        }

        // Metoda szukająca wartość najwyższą w tablicy
        public int SzukajMax(int[] tablica)
        {
            int max = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                {
                    max = tablica[i];
                }
            }
            return max;
        }
    }
}
