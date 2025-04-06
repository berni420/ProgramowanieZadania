def kalkulator():
    print("ZADANIE 1: kalkulator dwóch liczb")
    a = float(input("podaj pierwsza liczbe: "))
    b = float(input("podaj druga liczbe: "))
    operacja = input("wybierz operacje (+, -, *, /): ")

    if operacja == '+':
        wynik = a + b
    elif operacja == '-':
        wynik = a - b
    elif operacja == '*':
        wynik = a * b
    elif operacja == '/':
        if b != 0:
            wynik = a / b
        else:
            print("error: nie dziel przez zero!")
            return
    else:
        print("Error")
        return

    print(f"Wynik: {wynik}")


def konwerter_temperatur():
    print("ZADANIE 2: konwerter temperatur")
    kierunek = input("wybierz kierunek konwersji (C -> F (wpisz C) lub F -> C (wpisz F)): ").upper()
    temp = float(input("podaj temperature: "))

    if kierunek == 'C':
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.2f}°F")
    elif kierunek == 'F':
        wynik = (temp - 32) / 1.82
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("error: zly wybor")


def srednia_ocen():
    print("ZADANIE 3: srednia ocen ucznia")
    n = int(input("ile ocen chcesz wprowadzic? "))
    suma = 0

    for i in range(n):
        ocena = float(input(f"podaj ocene {i + 1}: "))
        suma += ocena

    srednia = suma / n
    print(f"srednia: {srednia:.2f}")
    if srednia >= 3.0:
        print("zdal")
    else:
        print("nie zdal")


def menu():
    while True:
        print("\n=== MENU ===")
        print("1 : kalkulator")
        print("2 : konwerter temperatur")
        print("3 : srednia ocen")
        print("0 : Exit")

        wybor = input("wybierz numer zadania: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "0":
            print("Zakończono program")
            break
        else:
            print("error")

menu()
