# ATM Simulator Exercise

Write a program that simulates an ATM machine for testing. The program should allow a user to:

* Enter an amount to Withdraw on Debit or Credit[^1]
* Print the dispensed money notes to the console

## Constraints

* Limit the amount of money that can be withdrawn to �600
* Dispense money in multiples of 10, 20, 50
* Dispense the least amount of paper money possible
* Validate the user withdrawal amount request and only dispense valid amounts of paper money

## Sample Outputs

```text
Please enter the amount you would like to withdraw: 123
The amount you requested is not valid.
This ATM can only dispense amounts in multiples of 10.
```

> Invalid Amount Request of 123

```text
Please enter the amount you would like to withdraw: 610
This ATM can only dispense amounts up to �600.
```

> Invalid Amount Request of 610

```text
Please enter the amount you would like to withdraw: 80
Dispensing 1 x 50 note
Dispensing 1 x 20 note
Dispensing 1 x 10 note
```

> Valid Amount Request of 80

```text
Please enter the amount you would like to withdraw: 120
Dispensing 2 x 50 notes
Dispensing 1 x 20 note
```

> Valid Amount Request of 120

```text
Please enter the amount you would like to withdraw: 600
Dispensing 12 x 50 notes
```

> Valid Amount Request of 600

---

## Coding Skills to Test

* Conditional Statements
* Console Input/Output
* Functions
* Math Operations

Copyright &copy; 2021 Mark Crowe <https://github.com/marcocrowe>. All rights reserved.

[^1]:  Because this is a simulation, you can assume that the user is always in good credit and the ATM will always dispense money to the user.