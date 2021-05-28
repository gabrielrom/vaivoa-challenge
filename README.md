<h1 align="center">Creadit Card Generate 🔥</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000" />
  <a href="#" target="_blank">
    <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  </a>
  <a href="https://twitter.com/gabrieIrom" target="_blank">
    <img alt="Twitter: https://twitter.com/gabrieIrom" src="https://img.shields.io/twitter/follow/gabrieIrom.svg?style=social" />
  </a>
</p>

> Creadit Card Generate is an API to generate credit card numbers!

## Prerequisites
* Docker
* Docker Compose
* .NET Core SDK (3.1)

## Advices
This application is using Docker and Docker Compose to create a container with postgres database, so you dont need to have installed on your computer postgres.

## Run application
```sh
docker-compose up -d
```
This command create a container with postgres and run it on background.

```sh
dotnet run
```
This command run the application.

## Routes
The application is running on http://localhost:3333

* POST: running on route /cards, this route needs of a email body param.
```sh
{
  "id": "5cefcb68-539e-417d-a754-75079ec1387d",
  "card_number": "4733972376918743",
  "email": "email@gmail.com",
  "created_at": "2021-05-28T04:31:02.946263"
}
```

* GET: running on route /cards?email="", this route return a list of all credit card number generated of a client by email 
provided by a query param.
```sh
[
  {
    "id": "5cefcb68-539e-417d-a754-75079ec1387d",
    "card_number": "4733972376918743",
    "email": "email@gmail.com",
    "created_at": "2021-05-28T04:31:02.946263"
  }
]
```


## Author

👤 **Gabriel Matheus**

* Twitter: [@gabrielrom](https://twitter.com/gabrieIrom)
* Github: [@gabrielrom](https://github.com/gabrielrom)
* LinkedIn: [@gabrielrom](https://linkedin.com/in/gabrielrom)

## Show your support

Give a ⭐️ if this project helped you!

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_