Employee Management System - Abstraction Example
Overview
This project simulates a basic employee management system using object-oriented programming principles, specifically focusing on abstraction. The goal is to represent different types of employees in a company, where each employee has common properties like Name, Surname, and Department. However, each employee's role (or task) is unique, and this role is implemented using an abstract method.

Problem Statement
Imagine you are writing a program to represent the employees of a company. Every employee has common attributes such as:

Name
Surname
Department
However, each employee's task or position is different. For example, you may have:

A Software Developer
A Project Manager
A Sales Representative
When the Mission method is called on each employee, they should describe their specific role.

For instance, consider an employee named Hasan Çıldırmış, who is a Project Manager. When the Mission() abstract method is called on Hasan's instance, the console should output:


