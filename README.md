# Car Factory Simulation

This project simulates a car factory where users can produce cars and manage a list of produced cars. The program interacts with the user via the console, asking for car details and managing user input validation.

## Features

- **Car Production:** Users can produce cars by entering details such as serial number, brand, model, color, and number of doors.
- **Input Validation:** Ensures valid input for the number of doors and prompts the user for correct input if an invalid entry is made.
- **Car List Management:** Displays a list of all produced cars with their serial numbers and brands when the user decides to stop producing cars.

## Usage

1. **Start the Program:**
   - Run the program to start the car factory simulation.

2. **Produce a Car:**
   - When prompted with "Do you want to produce a car? (y/n)", enter `y` to start producing a car or `n` to exit the program.

3. **Enter Car Details:**
   - **Serial Number:** Input the serial number of the car.
   - **Brand:** Enter the brand of the car.
   - **Model:** Provide the model of the car.
   - **Color:** Specify the color of the car.
   - **Number of Doors:** Enter the number of doors (2 or 4). If a non-numeric or invalid value is entered, the program will prompt for a valid number.

4. **Produce Another Car:**
   - After entering all details for one car, you will be asked if you want to produce another car. Enter `y` to continue producing cars or `n` to end the process.

5. **View Car List:**
   - If you choose to stop producing cars, the program will display a list of all produced cars with their serial numbers and brands.

## Error Handling

- **Invalid Input for Car Production:** If an input other than `y` or `n` is provided when asked if the user wants to produce a car or another car, the program will show an error message and prompt for valid input.
- **Invalid Door Number:** If a door number other than 2 or 4 is entered, the program will show an error message and ask for the door number again.
- **Non-Numeric Door Input:** If a non-numeric value is entered for the number of doors, the program will catch the exception and prompt for a valid number.

## Requirements

- .NET runtime for executing the C# program.
- Console application support.

![image](https://github.com/user-attachments/assets/6e3dbd84-dccc-47bd-b222-00ab40f90b6e)
