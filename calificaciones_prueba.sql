
--Creamos la base de datos
create database prueba_calificaciones



--Creamos una tabla donde se tendra la informacion de los alumnos
create table tmp_alumnos
(id int primary key identity ,
nombres varchar(100)not null,
apellido_paterno varchar(50)not null,
apellido_materno  varchar (50),
fecha_nacimiento date not null,
grado int not null,
grupo varchar(5)
)


--Creamos una tabla donde se tendra la informacion de las calificaciones
Create table tmp_calificaciones
(id_alumno int not null ,
id_maestro int not null,
grado int not null,
grupo varchar(5),
materia varchar (100)not null,
calificacion decimal not null
)


--Creamos una tabla donde se tendra la informacion de las materias
Create table tmp_materias
(id int primary key  not null,
nombre_materia varchar(100)not null,
descripcion_materia varchar(500)not null,
seccion varchar(100)not null
)


--Creamos una tabla donde se tendra la informacion de los maestros
create table tmp_maestros
(id int primary key not null,
nombres varchar (100) not null,
apellido_paterno varchar(50)not null,
apellido_materno  varchar (50),
fecha_nacimiento date not null,
especialidad varchar (100)
)






--Scripts para insertar informacion de las calificaciones

insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,1,1,'A','español',7)

insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,2,1,'A','matematicas',7)


insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,3,1,'A','ciencias naturales',7)


insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,4,1,'A','historia',9)


insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,5,1,'A','computacion',10)


insert into tmp_calificaciones(id_alumno,id_maestro,grado,grupo,materia,calificacion)
values(20,1,1,'A','geografia',10)





--Scripts para insertar informacion de los maestros

insert into tmp_maestros(nombres,apellido_paterno,apellido_materno,fecha_nacimiento,especialidad)
values('Jorge','Crespo','Crespo','1982-04-08','Ciencias basicas')


insert into tmp_maestros(nombres,apellido_paterno,apellido_materno,fecha_nacimiento,especialidad)
values('Nestor Jacobo','Espinoza','Crespo','1982-04-08','algebra')

insert into tmp_maestros(nombres,apellido_paterno,apellido_materno,fecha_nacimiento,especialidad)
values('Daniel emlilio','islas','salas','1982-04-08','Ciencias de la computacion')

insert into tmp_maestros(nombres,apellido_paterno,apellido_materno,fecha_nacimiento,especialidad)
values('Eliana','sapien','lizarraga','1982-04-08','Ciencias basicas')

insert into tmp_maestros(nombres,apellido_paterno,apellido_materno,fecha_nacimiento,especialidad)
values('Edna lizbeth','Camacho','Lizarraga','1982-04-08','Ciencias basicas')




--Scripts para insertar informacion de las materias

insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('español','aprender a leer y escribir','ciencias basicas')


insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('matematicas','aprender a restar y sumar','algebra')

insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('ciencias naturales','aprender de la naturaleza','ciencias basicas')

insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('historia','aprender sobre la historia de mexico','ciencias basicas')

insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('computacion','aprender a usar la computadora','ciencias de la computacion')


insert into tmp_materias(nombre_materia,descripcion_materia,seccion)
values('geografia','aprender sobre la geografia del pais','ciencias basicas')




--Scripts para insertar informacion de los alumnos

insert into tmp_alumnos (nombres,apellido_paterno,apellido_materno,fecha_nacimiento,grado,grupo)
values ('noe','rivas','lopez','1992-04-08',1,'A')









--Script que nos retorna a los 10 mejores alumnos oredenados por el promedio

select top 10
avg(calificacion) as promedio,
ta.nombres as nombrealumno
from  tmp_calificaciones tc
inner join tmp_alumnos ta
on tc.id_alumno = ta.id
group by id_alumno ,ta.nombres
order by promedio desc  
