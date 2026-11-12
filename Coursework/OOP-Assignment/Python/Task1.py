# PROGRAMMING BASICS - TASK 1
# Arithmetic Calculator, Temperature Converter and GPA Calculator


# TASK 1: ARITHMETIC CALCULATOR

def arithmetic_calculator():
    print("\n--- Arithmetic Calculator ---")

    number_one = float(input("Enter number 1: "))
    number_two = float(input("Enter number 2: "))
    operand = input("Enter operand (+, -, *, /): ")

    if operand == '+':
        print("Result:", number_one + number_two)

    elif operand == '-':
        print("Result:", number_one - number_two)

    elif operand == '*':
        print("Result:", number_one * number_two)

    elif operand == '/':
        if number_two == 0:
            print("Cannot divide by 0")
        else:
            print("Result:", number_one / number_two)

    else:
        print("Invalid operand input")


# TASK 2: TEMPERATURE CONVERTER

def temperature_converter():
    print("\n--- Temperature Converter ---")
    print("C - Celsius to Fahrenheit")
    print("F - Fahrenheit to Celsius")

    unit = input("Enter conversion direction: ").upper()

    if unit == "C":
        celsius = float(input("Enter temperature in Celsius: "))

        if celsius < -273.15:
            print("Invalid Temperature")
        else:
            fahrenheit = (celsius * 9 / 5) + 32
            print("Temperature in Fahrenheit:", fahrenheit)

    elif unit == "F":
        fahrenheit = float(input("Enter temperature in Fahrenheit: "))

        if fahrenheit < -459.67:
            print("Invalid Temperature")
        else:
            celsius = (fahrenheit - 32) * 5 / 9
            print("Temperature in Celsius:", celsius)

    else:
        print("Invalid conversion direction")


# TASK 3: STUDENT GRADE POINT AVERAGE

def gpa_calculator():
    print("\n--- GPA Calculator ---")

    number_of_grades = int(input("Enter the number of grades: "))

    while number_of_grades <= 0:
        print("Invalid number of grades")
        number_of_grades = int(input("Enter the number of grades: "))

    total = 0
    i = 0

    while i < number_of_grades:
        print("Enter grade", i + 1, ": ")
        score = float(input())

        if score < 1 or score > 6:
            print("Invalid grade. Enter a grade between 1 and 6.")
            continue

        total += score
        i += 1

    average = total / number_of_grades

    print("Average:", format(average, ".2f"))

    if average >= 3.0:
        print("The student passed.")
    else:
        print("The student failed.")


# MAIN MENU

while True:
    print("\n========== PROGRAMMING TASKS ==========")
    print("1. Arithmetic Calculator")
    print("2. Temperature Converter")
    print("3. GPA Calculator")
    print("4. Exit")
    print("=======================================")

    choice = input("Select a task (1-4): ")

    if choice == "1":
        arithmetic_calculator()

    elif choice == "2":
        temperature_converter()

    elif choice == "3":
        gpa_calculator()

    elif choice == "4":
        print("Exiting program...")
        break

    else:
        print("Invalid selection. Please select 1-4.")
