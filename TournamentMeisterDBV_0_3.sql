use TournamentMeisterDB

create table Users(
	id_user int primary key,
	username varchar(100),
	correo varchar(100),
	usr_password varchar(100)
)

create table Tournaments(
	id_tournament int primary key,
	id_config int references TournamentConfiguration,
	has_started binary,
	has_ended binary,
	participant_limit int,
	id_t_theme int references TournamentThemes,
	t_state varchar(200)
)

create table TournamentThemes(
	id_ttype int primary key,
	ttype_name varchar(50),
)


create table TournamentConfiguration(
	id_config int primary key,
	has_started binary,
	has_ended binary,
	participant_limit int,
	t_state varchar(200)
)

create table Moderators(
	id_user int references Users,
	id_tournament int references Tournaments,
	primary key(id_user,id_tournament)
)

create table Participants(
	id_user int references Users,
	id_tournament int references Tournaments,
	score decimal,
	primary key(id_user,id_tournament)
)

create table Results(
	id_result int primary key,
	id_user int references Users,
	id_tournament int references Tournaments,
	place int
)