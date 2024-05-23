using System;

namespace SortowaniePrzezWybieranie
{
    class Program
    {


        // Metoda sortująca tablicę malejąco przez wybieranie
        /**************************************
        nazwa funkcji: SortowaniePrzezWybieranie
        * parametry wejściowe: int[] tablica - tablica liczb całkowitych do posortowania
        * wartość zwracana: (void)
        * autor: Varvara Yakubovych 3D
        *************************************/

        static void Main(string[] args)
        {
            // Inicjalizacja tablicy
            int[] tablica = new int[10];

            // Wczytanie danych do tablicy
            try
            {
                Console.WriteLine("Wprowadź 10 liczb całkowitych oddzielonych spacją:");
                string input = Console.ReadLine();
                string[] liczby = input.Split(' '); // Podzielenie wprowadzonego łańcucha na pojedyncze liczby

                // Konwersja i wpisanie liczb do tablicy
                for (int i = 0; i < 10; i++)
                {
                    tablica[i] = Convert.ToInt32(liczby[i]); // Konwersja każdej liczby na int i wpisanie do tablicy
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas konwersji danych: {ex.Message}");
                return; // Zakończenie działania programu
            }

            // Utworzenie obiektu klasy Sortowanie
            Sortowanie sort = new Sortowanie();

            // Wywołanie metody sortującej
            sort.SortowaniePrzezWybieranie(tablica);

            // Wyświetlenie posortowanej tablicy
            Console.WriteLine("Posortowana tablica malejąco:");
            foreach (int liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();

            // Znalezienie i wyświetlenie wartości maksymalnej
            int max = sort.SzukajMax(tablica);
            Console.WriteLine($"Wartość maksymalna w tablicy: {max}");
        }
    }
}
