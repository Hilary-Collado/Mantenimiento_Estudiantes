 create database universidad

 USE universidad


 CREATE TABLE estudiante(
codigo_estudiante int IDENTITY(1,1) PRIMARY KEY,
matricula INT NOT NULL,
nombre varchar(35) NOT NULL,
apellido varchar(35) NOT NULL,
fecha_nacimiento date NOT NULL,
carrera varchar(60) NOT NULL,
estado char NOT NULL,
CONSTRAINT tamano_matricula CHECK (LEN(CONVERT(VARCHAR, matricula)) = 7)
);
