# Selection exercises

### Excercise 1
Enter 2 numbers. The intention is that we will calculate the difference, but we will always subtract the smallest number from the largest. Make a program that reads these two numbers and calculates and prints the difference.

---

### Excercise 2

Read in two numbers and divide the first number by the second. Consider dividing by zero.
If we want to divide by zero, we print the contents of number1 along with the message "is not divisible by 0".

---

### Excercise 3

The first name, last name and age must be read. The age group is now determined. Someone belongs to the 'Youth' age group if he/she is younger than 18, otherwise the age group is 'Adults'.
Restriction: In the solution, one may not use an Else branch in the selection used.

---

### Exercise 4

3 whole numbers must be read, one letter code 'A' or 'B' and a number code '1', '2' or '3'. The combination of the letter code and the number code determines which operation must be performed. Look carefully at the table below to find out the correct operation.

|               | Figurecode '1'      | Figurecode '2'      | Figurecode '3'      |
| ------------- |:-------------------:|:-------------------:|:-------------------:|
| Lettercode 'A'| Number 1 + number 2 | Number 2 + number 3 | Number 1 + number 3 |
| Lettercode 'B'| Number 1 - number 2 | Number 2 - number 3 | Number 1 - number 3 |

---

### Exercise 5

Calculate the points after throwing a dart at a bird cock. For this we have to check where the arrow ends up and depending on that the corresponding points are printed.

- landing place 1 = Outside the board: 0 points 
- landing place 2 = 0uter ring: 20 points
- landing place 3 = Inner ring: 50 points 
- landing place 4 = In the bull's eye: 100 points

---

### Exercise 6

Determine whether an entered year is a leap year or not.
The following rules apply:
1. For the years before 1582, the rule applies that if they are divisible by 4, the year is a leap year;
2. After 1582, the following regulation applies (only the condition that appears first applies)
  * Divisible by 4000 no leap year
  * Divisible by 400 or leap year
  * Divisible by 100 no leap year
  * Divisible by 4 or leap year

---

### Exercise 7

Four numbers must be entered, the smallest of which must be printed.
Try to solve this as efficiently as possible. It should be very easy to read in a 5th number later and still print the smallest.

---

### Exercise 8

Exercise 8
The user must enter his motto and can determine the screen colors for this motto.
He can choose from the background colors blue (B or b), red (R or r) and yellow (Y or y). He can choose from dark green (D or d), white (W or w) or cyan (C or c) for the colors for the letters.
If the user chooses a wrong color, no color is changed (the background color remains white and the font color remains dark blue).
After the user has entered the necessary information, the colors are adjusted and the read motto appears on a cleared screen.

---

### Exercise 9

3 numbers and a code are read.
If the code is 'A' or 'a', we calculate the sum of the 3 numbers.
If the code is 'B' or 'b', we calculate the product of the 1st number by the 3rd number.
If the code is 'C' or 'c', we calculate the difference between the 3rd number and the 2nd number.
If the code is 'D' or 'd', we calculate the square root of the 1st number if the 1st number is greater than zero. Otherwise, we print the message 'Sorry, we don't calculate the square roots of negative numbers or zero!'.
In all other cases we determine the largest number from the 3 numbers entered.

---

### Exercise 10

Many people practice one or more hobbies. You can buy a magazine for every hobby. The program requests the name and first name of the user. Then the user can choose from a list of hobbies. Depending on the chosen hobby, the program determines which magazine is best for the user to purchase. If the user makes a choice that is not in the list below, he will not receive a suggestion. Look carefully at the examples.

| Hobby                                   | Magazine               |
| --------------------------------------- | ---------------------- |
| Handicrafts (knitting, crocheting, ...) | Anna                   |
| Making clothing                         | Cuttie                 |
| Decorating the interior                 | VtLiving               |
| Playing football                        | Football International |
| Riding a bike                           | Hiking & Cycling       |
| Photography                             | Zoom NL                |
| Running                                 | Runners                |
