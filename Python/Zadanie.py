import sys

def zadanie_1_kalkulator():
    print("\n--- Zadanie 1: Prosty Kalkulator ---")
    try:
        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        op = input("Wybierz operację (+, -, *, /): ")

        wynik = 0
        if op == '+':
            wynik = a + b
        elif op == '-':
            wynik = a - b
        elif op == '*':
            wynik = a * b
        elif op == '/':
            if b == 0:
                print("Błąd: Nie można dzielić przez zero!")
                return
            wynik = a / b
        else:
            print("Nieznana operacja.")
            return

        print(f"Wynik: {wynik}")
    except ValueError:
        print("Błąd: Podano nieprawidłową liczbę.")

def zadanie_2_temperatura():
    print("\n--- Zadanie 2: Konwerter Temperatur ---")
    try:
        kierunek = input("Wybierz konwersję (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ").upper()
        
        if kierunek == 'C':
            c = float(input("Podaj temperaturę w Celsjuszach: "))
            f = c * 1.8 + 32
            print(f"{c}°C = {f:.2f}°F")
        elif kierunek == 'F':
            f = float(input("Podaj temperaturę w Fahrenheitach: "))
            c = (f - 32) / 1.8
            print(f"{f}°F = {c:.2f}°C")
        else:
            print("Nieznany wybór konwersji.")
    except ValueError:
        print("Błąd: Podano nieprawidłową wartość temperatury.")


# --- MENU GŁÓWNE ---
def main():
    while True:
        print("\n================ MENU ================")
        print("1. Prosty kalkulator")
        print("2. Konwerter temperatur")
        print("0. Wyjście")
        
        wybor = input("Wybierz zadanie (0-2): ")

        if wybor == '1':
            zadanie_1_kalkulator()
        elif wybor == '2':
            zadanie_2_temperatura()
        elif wybor == '0':
            print("Zamykanie programu...")
            break
        else:
            print("Nieprawidłowy wybór, spróbuj ponownie.")

if __name__ == "__main__":
    main()