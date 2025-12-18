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
# --- MENU GŁÓWNE ---
def main():
    while True:
        print("\n MENU ")
        print("1. Prosty kalkulator")
        print("0. Wyjście")
        
        wybor = input("Wybierz zadanie (0-1): ")

        if wybor == '1':
            zadanie_1_kalkulator()
        elif wybor == '0':
            print("Zamykanie programu...")
            break
        else:
            print("Nieprawidłowy wybór, spróbuj ponownie.")

if __name__ == "__main__":
    main()