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

--><returns> <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Greetings to 12 people</string></returns>

## Question 5: Controller that has an input {id}, and applies four mathematical operations to it.
`
GET http://localhost:50987/api/numbermachine/5
`

--><returns> <ArrayOfstring xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
        <string> Addition 7</string>
        <string> Substraction 3</string>
        <string> Multiplication 10</string>
        <string> Division 2</string>
        </ArrayOfstring>
   </returns>

## Question 6: Initiative Question.

You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance, plus an additional 13% HST. The input {id} represents the number of days which has elapsed since the beginning of the hosting. Output 3 strings which describe the total hosting cost.
`
GET http://localhost:50987/api/hostingcost/5
`

--><returns> <ArrayOfstring xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
        <string>1 fortnights at $5.50/FN = $5.50 CAD</string>
        <string>HST 13% = $0.72</string>
        <string>Total = $6.22</string>
        </ArrayOfstring>
        
  </returns>
