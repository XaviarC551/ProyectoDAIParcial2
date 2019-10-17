use ProyectoTorneo

create table torneo(
	cTorneo int primary key,
	nombre varchar(100),
	ganador varchar(100),
	enProceso bit)

create table partida(
	cPartida int primary key,
	numPartida int,
	puntos1 int,
	puntos2 int,
	ganador varchar(100),
	cTorneo int references torneo)

create table usuario(
	cUsuario int primary key,
	nombre varchar(100),
	username varchar(100),
	contrasena varchar(100),
	esEspectador bit,
	cTorneo int references torneo,
	cPartida int references partida)

	select * from torneo
	select * from usuario