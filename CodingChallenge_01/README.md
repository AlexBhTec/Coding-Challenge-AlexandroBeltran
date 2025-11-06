# Coding Challenge 1 - Shape Area Calculator

## Description
You are building a simple drawing program that needs to calculate the area of different geometric shapes.
Every shape shares the same basic behavior — it can calculate its area — but each shape does so in a different way.

Your task is to design a set of classes using **Object-Oriented Programming (OOP)** concepts such as **Inheritance** and **Polymorphism** to compute the area for multiple shapes.

## Requirements

**1. Base Class** `Shape`
   
  - Defines a method `getArea()` which will be overridden by derived classes.
  - Can be treated as an abstract class (should not be instantiated directly).
    
**2. Derived Classes**

   `Circle`
   - Attributes: `radius`
   - Formula: `π * radius²`

   `Rectangle`
   - Attributes: `width`, `height`
   - Formula: `width * height`
  
   `Triangle`
   - Attributes: `base`, `height`
   - Formula: `(base * height) / 2`

   Each derived class must override the `getArea()` method from `Shape`.

## Input
The program receives no direct input.

## Output
```
Area: 78.54
Area: 24
Area: 6
```

## Constrains
- All numeric values are positive integers or floating-point numbers.
- The value of **π** can be approximated as **3.1416**.
- You must use Inheritance and Polymorphism — avoid using conditional statements to differentiate shapes.
