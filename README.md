# ApiRestPokeapp

Conexion de BD con sql server management developer

Nombre de Base de datos Pokedex

Editar appsettings.json para adecuarlo a tu pc 

"ConexionSql": "Data Source=.;INITIAL CATALOG=Pokedex;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" -- sin docker

"ConexionSql": "Server=host.docker.internal;Database=Pokedex;User=SA;Password=Yourpassword123" -- con docker

Cambiar "Yourpassword123" por tu password SA en docker-compose.yml , appsettings.json
