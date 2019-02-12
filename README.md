REST Controllers and Services
=============================
## Overview

In this assignment students are tasked with creating a small RESTful API that simulates a backend for a quiz-like application. Data will be stored in a postgreSQL database and Entity Framework Core will be used to interact with the database.

### Summary of the API
Each entity should be identified by a unique Id column which should be configured as the primary key for that entity.

Each `Quiz` should contain a `title` field. Each `Quiz` contains a collection of `Question` entities. `Questions` entities also contain a unique `text` field representing the text of the question. Each question contains a collection of `Answer` elements which are uniquely identified by their own `text` field representing the text of the answer. The `Answer` entity will also contain a field signifying if it is the correct answer for the question it belongs to.

---

This assignment is intentionally lacking in it's description of required services and entities/models. It is up to the student to decide how to model the requests, responses, and organize the business logic to meet the specified requirements. 

### Requirements

You will need to create/implement the following endpoints and their required services

- [ ] `GET quiz`
    - Returns the collection of `Quiz` elements

- [ ] `POST quiz`

    Creates a quiz and adds to collection
    - Returns the `Quiz` that it created

- [ ] `DELETE quiz/{quizName}`

    Deletes the specified quiz from collection
    - Returns the deleted `Quiz`

- [ ] `PATCH quiz/{quizName}/rename/{newName}`

    Rename the specified quiz using the new name given
    - Returns the renamed `Quiz`

- [ ] `PATCH quiz/{quizName}/add`

    Adds a question to the specified quiz
    - Receives a `Question`
    - Returns the modified `Quiz`

- [ ] `DELETE quiz/{quizName}/delete/{questionId}`

    Deletes the specified question from the specified quiz
    - Returns the deleted `Question`
