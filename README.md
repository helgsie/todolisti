# To-do listi

Einfalt REST API með .NET Core

- GET /api/todo → Sækir öll verkefni
- POST /api/todo → Býr til verkefni
- DELETE /api/todo/{id} → Eyðir verkefni eftir id

Hægt er að keyra verkefnið á `http://localhost:5193` með `dotnet run`

## API Prófanir
### Swagger
Hægt að skoða á `http://localhost:5193/swagger` í vafranum.

### Postman
- `GET → http://localhost:5193/api/todo`
- `POST → http://localhost:5193/api/todo`
- `DELETE → http://localhost:5193/api/todo/{id}`

