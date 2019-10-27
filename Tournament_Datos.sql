use TournamentMeisterDB

alter table Tournaments add tournament_name varchar(100)

insert into Users values(4, 'alan24', 'alan.2411@gmail.com', 'alansuki')
insert into Users values(2, 'pau3345', 'paula@gmail.com', 'langle')
insert into Users values(3, 'josekarl', 'josevac@hotmail.com', 'vaca')

insert into TournamentThemes values(01, 'smash')
insert into TournamentThemes values(02, 'lol')

insert into TournamentConfiguration values (101, 0, 0, 25, 'California')
insert into TournamentConfiguration values (102, 1, 1, 763, 'CDMX')
insert into TournamentConfiguration values(103, 1, 0, 42, 'Guadalajara')

insert into Tournaments values(1001, 101, 0, 0, 382, 01, 'Nuevo León', 'Ultimate Smash Tournament')
insert into Tournaments values(2002, 102, 1, 1, 5000, 01, 'CDMX', 'Champions Face-Off')
insert into Tournaments values(3025, 103, 1, 0, 84, 02, 'Miami', 'Worldwide Championship')

insert into Results values(001, 1, 3025, 2)
insert into Results values(002, 4, 2002, 3)
insert into Results values(003, 2, 1001, 1)

insert into Participants values(3, 2002, 1075)
insert into Participants values(2, 3025, 5827)
insert into Participants values(1, 1001, 382)

insert into Moderators values(4, 2002)
insert into Moderators values(2, 1001)





