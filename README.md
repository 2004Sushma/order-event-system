# Real-Time Order Notifications

## Description

This is a console application that I made using C#. It shows how the Publisher-Subscriber model works using delegates and events. The system takes an order. Tells many services when an order is placed. The user can enter information when the program is running.

## Features

- We can process orders with information from the user

- I used a delegate to make it work

- The system sends out notifications when something happens

- Many services get these notifications like Email, SMS and a Logger

- The publisher-subscriber model helps keep everything separate

## Technologies Used

- I used C# to make this

- It is a.NET Console Application

## How It Works

- The user enters the Order ID, Customer Name and Amount

- The OrderProcessor is like the person who tells everyone what is happening

- The EmailService, SMSService and LoggerService are like the people who get told

- When an order is placed something happens to trigger an event

- All the services that are listening get notified

## Sample Output

Enter Order ID: 101

Enter Customer Name: Sushma

Enter Amount: 500

Order Placed: 101

We sent an email to the customer

We sent an SMS to the customer

The order was logged successfully

## Concepts Used

- Delegates are like messengers

- Multicast Delegates can tell people at once

- Events are like things that happen

- The Publisher-Subscriber Model is like a way of telling people what is happening without bothering them

- Loose Coupling means that everything is separate and does not get in the way of other things

## How to Run

1. Open the project in Visual Studio

2. Build the solution

3. Run the application

4. Enter the order details when you are asked

5. Look at the output, in the console

## Author

Sushma
