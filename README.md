### Assignment 1: Yash Modi
This repo contains HTTP 5112-assignment 1.

## Tasks
It is to use ASP.NET WebAPI controllers to create Application Programming Interfaces(APIs).

## Question 1: Controller that returns 10 more than the integer input {id}.(AddTenController)
`
GET http://localhost:50987/api/addten/21
`

-->
 <returns> <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">31</int> </returns>

## Question 2: Controller that returns the square of the integer input {id}.
`
GET http://localhost:50987/api/square/2
`

--><returns> <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</int></returns>

## Question 3: Controller that returns the string “Hello World!.
`
POST  http://localhost:50987/api/greeting/
`

-->curl -d . http://localhost:50987/api/greeting
"Hello World!"

## Question 4: Controller that returns the string “Greetings to {id} people!” where id is an integer value.
`
GET http://localhost:50987/api/greeting/12
`

--><returns> <int xmlns="http://schemas.microsoft.com/2003/10/Serialization/">4</int></returns>


