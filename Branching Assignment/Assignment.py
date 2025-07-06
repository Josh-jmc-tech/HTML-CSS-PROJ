# Constants for limits and calculations
MAX_WEIGHT = 50.0
MAX_DIMENSION_TOTAL = 50.0
QUOTE_DIVISOR = 100.0

def main():
    print("Welcome to Package Express. Please follow the instructions below.")
    
    try:
        # Prompt for weight with unit clarification
        weight = float(input("Please enter the package weight (in pounds):\n"))
        if weight <= 0:
            print("Weight must be greater than zero.")
            return
        if weight > MAX_WEIGHT:
            print(f"Package too heavy (>{MAX_WEIGHT} pounds) to be shipped via Package Express. Have a good day.")
            return

        # Prompt for dimensions
        width = float(input("Please enter the package width (in inches):\n"))
        if width <= 0:
            print("Width must be greater than zero.")
            return
            
        height = float(input("Please enter the package height (in inches):\n"))
        if height <= 0:
            print("Height must be greater than zero.")
            return
            
        length = float(input("Please enter the package length (in inches):\n"))
        if length <= 0:
            print("Length must be greater than zero.")
            return

        # Check total dimensions
        dimension_total = width + height + length
        if dimension_total > MAX_DIMENSION_TOTAL:
            print(f"Package too large (total dimensions > {MAX_DIMENSION_TOTAL} inches) to be shipped via Package Express.")
            return

        # Calculate and display quote
        volume = width * height * length
        quote = (volume * weight) / QUOTE_DIVISOR
        print(f"Your estimated total for shipping this package is: ${quote:.2f}")
        print("Thank you!")

    except ValueError:
        print("Invalid input. Please enter numeric values only for weight and dimensions.")

if __name__ == "__main__":
    main()