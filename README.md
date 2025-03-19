# todolisti
Einfalt REST API með .NET Core. Hægt er að gera eftirfarandi:

- GET /api/todo → Sækir öll to-do verkefni
- POST /api/todo → Býr til to-do verkefni
```
{
  "task": "Gera heimanám",
  "isCompleted": false
}
```
- PUT /api/todo → Uppfærir to-do verkefni eftir id
```
{
  "task": "Þvo þvott",
  "isCompleted": true
}
```
- DELETE /api/todo/{id} → Eyðir to-do verkefni eftir id

## Keyrsla og API Prófanir
Hægt er að keyra verkefnið á `http://localhost:5193` með `dotnet run`

### Swagger
Hægt að skoða á `http://localhost:5193/swagger` í vafranum.

### Postman
- `GET → http://localhost:5193/api/todo`
- `POST → http://localhost:5193/api/todo`
- `PUT → http://localhost:5193/api/todo/{id}`
```
{
  "task": "Uppfært verkefni",
  "isCompleted": false
}
```
- `DELETE → http://localhost:5193/api/todo/{id}`

