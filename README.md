# Algorytmy-sortowania-i-wyszukiwania-moje-rozwi-zanie-
Zadanie zlecone w ramach przedmiotu "Metody numeryczne dla inżynierów" - 2 rok studiów Inżynierskich
ZADANIE DOMOWE 1
W ramach zadania domowego do pierwszych laboratoriów kontynuujemy pracę z algorytmami dotyczącymi
sortowania i wyszukiwania. Do tego dokonamy porównania dwóch plików za pomocą wcześniej poznanych
algorytmów.
Zapoznajcie się z poniższymi algorytmami i przygotujcie ich implementację dla zbioru danych (na początek może być
tablica liczb całkowitych). Pamiętajcie, że macie to zrealizować algorytmicznie (korzystając z pętli, instrukcji
sterujących, etc), a nie „językowo” (użycie sorter() czy find()).
Implementacja (poprawna, algorytmiczna!) wszystkich poniższych gwarantuje ocenę 5.0, a na ocenę 3.0 wystarczy
zrealizować dwa wybrane punkty (dla 1 i 2 minimum po 2 podpunkty, żeby zaliczyć cały punkt).
1) Zabawa w „zgadnij liczbę”
a) Napiszcie program, który będzie zgadywał (losując liczbę z przedziału domkniętego od 1 do 1000) wartość
podaną na początku przez użytkownika. Policzcie ile „zgadnięć” musiał wykonać program, zanim znalazł liczbę.
b) Usprawnijcie program z podpunktu a) tak, żeby po trafieniu zbyt wysokim (np. program strzela 800, a liczba
wynosi 500) zmniejszał górny zakres losowań (w tym wypadku do 799, ponieważ 800 jest już za duże), a po
zbyt niskim dolny zakres losowań (np. dla strzału 300 i powyższej liczby zgadywanej 500 dolny przedział
zaczynać się będzie od 301).
c) Przypomnijcie sobie zadanie 3 z laboratorium. Wyszukiwanie binarne potrafiło znaleźć (jeśli istnieje) ze
złożonością czasową O(log2 N) podaną wartość w uporządkowanym zbiorze. Wykorzystajcie ten schemat do
napisania algorytmu, który znajdzie podaną przez użytkownika liczbę.
2) Automatyzacja zadania z poprzedniego punktu
Wcześniej napisane programy (od a) do c) włącznie) zmodyfikujcie tak, żeby wpierw komputer losował (za pomocą
generatora liczb pseudo-losowych) liczbę do zgadnięcia, a następnie sam będzie próbował ją odgadnąć zgodnie z
zasadami podanymi w podpunktach. Uruchomcie program w pętli (np. milion razy) żeby przetestować w ilu próbach
średnio zajęło komputerowi zgadnięcie liczby z przedziału od 1 do 1000. Poniżej schemat ogólny zapisu
algorytmu wykonującego powyższy podpunkt:
Powtarzaj od i = 0 do i < 1 milion
{
Wylosuj LICZBA
Uruchom szukanie LICZBY( zlicz liczbę prób)
Zsumuj dotychczasową liczbę prób
}
Podaj średnia liczba prób = dotychczasowa liczba prób / 1 milion
3) Algorytm porównywania zawartości plików.
Zastanówcie się nad realizacją i zaimplementujcie własny algorytm, który sprawdzi które wartości występują tylko w
jednym pliku (kolor różowy) a które tylko w drugim (kolor żółty) oraz które są wspólne dla obu plików (kolor zielony).
Wystarczy wypisać informację na ekranie, nie trzeba używać kolorów 
