create database admin_hospital
create table laboratorio(
id_laboratorio int primary key not null,
nombre varchar (50),
telefono int,
direccion varchar(50)
);

create table via_administracion(
id_via_administracion int primary key not null,
nombre varchar(50)
);

create table presentacion(
id_presentacion int primary key not null,
presentacion varchar (50)
);

create table clasificacion(
id_clasificacion int primary key not null,
nombre_clasificacion varchar (50)
);

create table lote(
id_lote int primary key not null,
fecha_fabricacion date,
fecha_vencimiento date,
codigo_lote int,
id_laboratorio int,
constraint fk_laboratorio FOREIGN KEY(ID_LABORATORIO)references laboratorio(id_laboratorio) on delete cascade
);

create table inventarios(
id_inventario int primary key not null,
stock int,
fecha_ingreso date,
precio_compra decimal,
id_lote int
constraint fk_id_lote foreign key (id_lote) references lote (id_lote) on delete cascade
);

create table sucursales(
id_sucursal int primary key not null,
sucursal varchar(50)
);

create table medicamentos(
id_medicamento int primary key not null,
nombre_producto varchar (50),
precio_venta int,
id_presentacion int,
id_clasificacion int,
id_via_administracion int,
id_inventario int,
id_sucursal int,
constraint fk_id_presentacion foreign key (id_presentacion) references presentacion(id_presentacion) on delete cascade,
constraint fk_id_clasificacion foreign key (id_clasificacion) references clasificacion(id_clasificacion) on delete cascade,
constraint fk_id_via_administracion foreign key (id_via_administracion) references via_administracion (id_via_administracion) on delete cascade,
constraint fk_id_inventario foreign key (id_inventario) references inventarios (id_inventario) on delete cascade,
constraint id_sucursal foreign key (id_sucursal) references sucursales (id_sucursal) on delete cascade
);

create table prescripciones(
id_prescripcion int primary key not null,
prescripcion bit,
id_medicamento int,
constraint fk_id_medicamento foreign key (id_medicamento) references medicamentos(id_medicamento) on delete cascade
);

create table tipos_sangre(
id_tipo_sangre int primary key not null,
tipo varchar (50)
);

create table especialidades(
id_especialidad int primary key not null,
areas varchar(50)
);

create table usuarios(
id_ususario int primary key not null,
usuario varchar (50),
contraseña varchar (50)
);

create table pacientes(
id_paciente int primary key not null,
nombre varchar (50),
edad int,
sexo bit,
peso int,
estatura int,
id_tipo_sangre int
constraint fk_id_tipo_sangre foreign key (id_tipo_sangre) references tipos_sangre (id_tipo_sangre) on delete cascade
);

create table doctores(
id_doctor int primary key not null,
nombre varchar (50),
id_especialidad int,
id_usuario int,
id_paciente int,
constraint fk_id_especialidad foreign key (id_especialidad) references especialidades(id_especialidad) on delete cascade,
constraint fk_id_usuario foreign key (id_usuario) references usuarios(id_ususario) on delete cascade,
constraint fk_id_paciente foreign key (id_paciente) references pacientes(id_paciente) on delete cascade
);

create table citas (
id_cita int primary key not null,
fecha datetime,
id_doctor int,
constraint fk_id_doctor foreign key (id_doctor) references doctores (id_doctor) on delete cascade
);

create table recetas(
id_receta int primary key not null,
id_paciente int,
id_doctor int,
id_medicamento int,
constraint fk_id_paciente_recetas foreign key (id_paciente) references pacientes (id_paciente) on delete cascade,
constraint fk_id_doctor_recetas foreign key (id_doctor) references doctores (id_doctor) ,
constraint fk_id_medicamento_recetas foreign key (id_medicamento) references medicamentos (id_medicamento) on delete cascade
);

create table enfermeros(
id_enfermero int primary key not null,
nombre varchar (50),
edad int
);

create table limpieza(
id_limpieza int primary key not null,
nombre varchar (50),
edad int
);

create table cargo(
id_cargo int primary key not null,
id_doctor int,
id_enfermero int,
id_limpieza int,
constraint fk_id_cargo_doctor foreign key (id_doctor) references doctores(id_doctor) on delete cascade,
constraint fk_id_cargo_enfermero foreign key (id_enfermero) references enfermeros (id_enfermero) on delete cascade,
constraint fk_id_cargo_limpieza  foreign key (id_limpieza) references limpieza (id_limpieza) on delete cascade
);

create table empleados(
id_empleado int primary key not null,
nombre varchar (50),
edad int,
id_cargo int,
id_sucursal int,
constraint fk_id_cargo foreign key (id_cargo) references cargo(id_cargo) on delete cascade,
constraint fk_id_sucursal foreign key (id_sucursal) references sucursales (id_sucursal) on delete cascade
);

create table planilla(
id_planilla int primary key not null,
salario_base float,
renta float,
seguro float,
salario_neto float,
fecha_pago datetime,
numero_cuenta int,
id_empleado int,
constraint fk_id_empleado_planilla foreign key (id_empleado) references empleados(id_empleado) on delete cascade
);

create table farmacia(
id_farmacia int primary key not null,
id_empleado int,
id_receta int,
constraint fk_id_receta_farmacia foreign key (id_receta) references recetas(id_receta) on delete cascade,
constraint fk_id_empleado foreign key (id_empleado) references empleados(id_empleado)
);

INSERT INTO laboratorio (id_laboratorio, nombre, telefono, direccion) VALUES
(1, 'Laboratorio Central', 22220001, 'San Salvador, El Salvador'),
(2, 'Laboratorio de Investigación Médica', 22220002, 'Santa Ana, El Salvador'),
(3, 'Laboratorio Clínico del Este', 22220003, 'San Miguel, El Salvador'),
(4, 'Laboratorio BioSalud', 22220004, 'La Libertad, El Salvador'),
(5, 'Laboratorio SonsoMed', 22220005, 'Sonsonate, El Salvador');


INSERT INTO via_administracion (id_via_administracion, nombre) VALUES
(1, 'Oral'),
(2, 'Intravenosa'),
(3, 'Intramuscular'),
(4, 'Subcutánea'),
(5, 'Tópica'),
(6, 'Rectal'),
(7, 'Inhalatoria'),
(8, 'Intranasal'),
(9, 'Sublingual'),
(10, 'Intradérmica');


INSERT INTO presentacion (id_presentacion, presentacion) VALUES
(1, 'Tableta'),
(2, 'Cápsula'),
(3, 'Jarabe'),
(4, 'Suspensión'),
(5, 'Solución'),
(6, 'Crema'),
(7, 'Gel'),
(8, 'Parche'),
(9, 'Supositorio'),
(10, 'Inyectable');

INSERT INTO clasificacion (id_clasificacion, nombre_clasificacion) VALUES
(1, 'Analgésicos'),
(2, 'Antiinflamatorios'),
(3, 'Antibióticos'),
(4, 'Antipiréticos'),
(5, 'Antihistamínicos'),
(6, 'Antidepresivos'),
(7, 'Antieméticos'),
(8, 'Antivirales'),
(9, 'Antifúngicos'),
(10, 'Anticonceptivos');


INSERT INTO lote (id_lote, fecha_fabricacion, fecha_vencimiento, codigo_lote, id_laboratorio) VALUES
(1, '2022-01-01', '2026-01-01', 123456, 1),
(2, '2022-02-01', '2026-02-01', 123457, 2),
(3, '2022-03-01', '2026-03-01', 123458, 3),
(4, '2022-04-01', '2026-04-01', 123459, 4),
(5, '2022-05-01', '2026-05-01', 123460, 5),
(6, '2022-06-01', '2026-06-01', 123461, 1),
(7, '2022-07-01', '2026-07-01', 123462, 2),
(8, '2022-08-01', '2026-08-01', 123463, 3),
(9, '2022-09-01', '2026-09-01', 123464, 4),
(10, '2022-10-01', '2026-10-01', 123465, 5);

INSERT INTO inventarios (id_inventario, stock, fecha_ingreso, precio_compra, id_lote) VALUES
(1, 100, '2024-05-01', 50.00, 1),
(2, 150, '2024-05-02', 60.00, 2),
(3, 200, '2024-05-03', 70.00, 3),
(4, 250, '2024-05-04', 80.00, 4),
(5, 300, '2024-05-05', 90.00, 5),
(6, 100, '2024-05-06', 55.00, 6),
(7, 150, '2024-05-07', 65.00, 7),
(8, 200, '2024-05-08', 75.00, 8),
(9, 250, '2024-05-09', 85.00, 9),
(10, 300, '2024-05-10', 95.00, 10)

INSERT INTO sucursales (id_sucursal, sucursal) VALUES
(1, 'Sucursal Santa Ana'),
(2, 'Sucursal San Salvador'),
(3, 'Sucursal San Miguel'),
(4, 'Sucursal La Libertad'),
(5, 'Sucursal Sonsonate');

INSERT INTO medicamentos (id_medicamento, nombre_producto, precio_venta, id_presentacion, id_clasificacion, id_via_administracion, id_inventario, id_sucursal) VALUES
(1, 'Paracetamol', 5, 1, 1, 1, 1, 1),
(2, 'Ibuprofeno', 8, 2, 1, 2, 2, 2),
(3, 'Amoxicilina', 10, 3, 3, 3, 3, 3),
(4, 'Loratadina', 6, 4, 5, 4, 4, 4),
(5, 'Omeprazol', 7, 5, 2, 5, 5, 5),
(6, 'Aspirina', 4, 6, 1, 6, 6, 1),
(7, 'Cetirizina', 9, 7, 5, 7, 7, 2),
(8, 'Diazepam', 12, 8, 6, 8, 8, 3),
(9, 'Acetaminofén', 6, 9, 1, 9, 9, 4),
(10, 'Levofloxacino', 15, 10, 3, 10, 10, 5),
(11, 'Dipirona', 5, 1, 1, 1, 1, 1),
(12, 'Metoclopramida', 8, 2, 1, 2, 2, 2),
(13, 'Azitromicina', 10, 3, 3, 3, 3, 3),
(14, 'Ciprofloxacino', 6, 4, 5, 4, 4, 4),
(15, 'Ranitidina', 7, 5, 2, 5, 5, 5),
(16, 'Diclofenaco', 4, 6, 1, 6, 6, 1),
(17, 'Escitalopram', 9, 7, 5, 7, 7, 2),
(18, 'Alprazolam', 12, 8, 6, 8, 8, 3),
(19, 'Dexametasona', 6, 9, 1, 9, 9, 4),
(20, 'Atorvastatina', 15, 10, 3, 10, 10, 5),
(21, 'Naproxeno', 5, 1, 1, 1, 1, 1),
(22, 'Metamizol', 8, 2, 1, 2, 2, 2),
(23, 'Penicilina', 10, 3, 3, 3, 3, 3),
(24, 'Cetoprofeno', 6, 4, 5, 4, 4, 4),
(25, 'Lansoprazol', 7, 5, 2, 5, 5, 5),
(26, 'Tramadol', 4, 6, 1, 6, 6, 1),
(27, 'Sertralina', 9, 7, 5, 7, 7, 2),
(28, 'Clonazepam', 12, 8, 6, 8, 8, 3),
(29, 'Diclofenaco Potásico', 6, 9, 1, 9, 9, 4),
(30, 'Losartán', 15, 10, 3, 10, 10, 5),
(31, 'Cefalexina', 5, 1, 1, 1, 1, 1),
(32, 'Metronidazol', 8, 2, 1, 2, 2, 2),
(33, 'Clarithromycin', 10, 3, 3, 3, 3, 3),
(34, 'Nimesulida', 6, 4, 5, 4, 4, 4),
(35, 'Esomeprazol', 7, 5, 2, 5, 5, 5),
(36, 'Piroxicam', 4, 6, 1, 6, 6, 1),
(37, 'Fluoxetina', 9, 7, 5, 7, 7, 2),
(38, 'Oxazepam', 12, 8, 6, 8, 8, 3),
(39, 'Paroxetina', 6, 9, 1, 9, 9, 4),
(40, 'Metformina', 15, 10, 3, 10, 10, 5),
(41, 'Aciclovir', 5, 1, 1, 1, 1, 1),
(42, 'Clotrimazol', 8, 2, 1, 2, 2, 2),
(43, 'Furosemida', 10, 3, 3, 3, 3, 3),
(44, 'Digoxina', 6, 4, 5, 4, 4, 4),
(45, 'Prednisona', 7, 5, 2, 5, 5, 5),
(46, 'Levotiroxina', 4, 6, 1, 6, 6, 1),
(47, 'Mirtazapina', 9, 7, 5, 7, 7, 2),
(48, 'Venlafaxina', 12, 8, 6, 8, 8, 3),
(49, 'Amitriptilina', 6, 9, 1, 9, 9, 4),
(50, 'Rosuvastatina', 15, 10, 3, 10, 10, 5);




-- Agregar datos a la tabla prescripciones con id_medicamento del 1 al 50
INSERT INTO prescripciones (id_prescripcion, prescripcion, id_medicamento) VALUES
(1, 1, 1),
(2, 0, 2),
(3, 1, 3),
(4, 0, 4),
(5, 1, 5),
(6, 0, 6),
(7, 1, 7),
(8, 0, 8),
(9, 1, 9),
(10, 0, 10),
(11, 1, 11),
(12, 0, 12),
(13, 1, 13),
(14, 0, 14),
(15, 1, 15),
(16, 0, 16),
(17, 1, 17),
(18, 0, 18),
(19, 1, 19),
(20, 0, 20),
(21, 1, 21),
(22, 0, 22),
(23, 1, 23),
(24, 0, 24),
(25, 1, 25),
(26, 0, 26),
(27, 1, 27),
(28, 0, 28),
(29, 1, 29),
(30, 0, 30),
(31, 1, 31),
(32, 0, 32),
(33, 1, 33),
(34, 0, 34),
(35, 1, 35),
(36, 0, 36),
(37, 1, 37),
(38, 0, 38),
(39, 1, 39),
(40, 0, 40),
(41, 1, 41),
(42, 0, 42),
(43, 1, 43),
(44, 0, 44),
(45, 1, 45),
(46, 0, 46),
(47, 1, 47),
(48, 0, 48),
(49, 1, 49),
(50, 0, 50);


INSERT INTO tipos_sangre (id_tipo_sangre, tipo) VALUES
(1, 'O+'),
(2, 'O-'),
(3, 'A+'),
(4, 'A-'),
(5, 'B+'),
(6, 'B-'),
(7, 'AB+'),
(8, 'AB-');

INSERT INTO especialidades (id_especialidad, areas) VALUES
(1, 'Cardiología'),
(2, 'Neurología'),
(3, 'Dermatología'),
(4, 'Gastroenterología'),
(5, 'Oftalmología'),
(6, 'Oncología'),
(7, 'Pediatría'),
(8, 'Psiquiatría'),
(9, 'Ginecología'),
(10, 'Ortopedia');
update  usuarios 
set usuario='cpleitez', contraseña = '1234'
where id_ususario = 1
select * from usuarios
INSERT INTO usuarios (id_ususario, usuario, contraseña) VALUES
(1, 'jdoe', 'P@ssw0rd123'),
(2, 'asmith', 'Secr3tP@ss'),
(3, 'rwilliams', 'MyP@ss2023'),
(4, 'ljohnson', 'P@ssw0rd!'),
(5, 'miller23', 'qwerty1234'),
(6, 'sarah89', 'S@rah89123'),
(7, 'michael77', 'M1ch@el2022'),
(8, 'kathryn', 'K@thryn2023!'),
(9, 'peter95', 'P3t3rP@ssw0rd'),
(10, 'emily', '3m!lyP@ssw0rd'),
(11, 'david.m', 'Dav1dM@il2022'),
(12, 'linda.j', 'L1nd@J0hnson'),
(13, 'robert', 'R0b3rtP@ss!'),
(14, 'anna', 'Ann@S3cr3t'),
(15, 'thomas', 'Th0m@sP@ss2023'),
(16, 'susan', 'SUS@N2022'),
(17, 'kevin34', 'K3v1nR0ckS!'),
(18, 'laura.m', 'Laur@M@il2023'),
(19, 'matthew', 'M@ttH3w2022'),
(20, 'hannah', 'H@nn@hP@ssw0rd'),
(21, 'james88', 'J@m3s88P@ss'),
(22, 'olivia', 'Oliv!@P@ss'),
(23, 'andrew.b', 'A.ndr3w2022'),
(24, 'amanda', 'Amand@P@ss123'),
(25, 'william', 'W1ll1@mP@ssw0rd');


INSERT INTO pacientes (id_paciente, nombre, edad, sexo, peso, estatura, id_tipo_sangre) VALUES
(1, 'María López', 35, 0, 65, 165, 3),
(2, 'Juan Martínez', 45, 1, 80, 175, 1),
(3, 'Ana García', 28, 0, 55, 160, 2),
(4, 'Carlos Rodríguez', 50, 1, 90, 180, 4),
(5, 'Laura Pérez', 22, 0, 50, 155, 1),
(6, 'Luis González', 60, 1, 75, 170, 2),
(7, 'Sofía Hernández', 40, 0, 68, 163, 3),
(8, 'Diego Díaz', 33, 1, 78, 178, 4),
(9, 'Valentina Castro', 29, 0, 60, 162, 2),
(10, 'Gabriel Ramírez', 55, 1, 85, 175, 1),
(11, 'Fernanda Sánchez', 42, 0, 70, 165, 3),
(12, 'José Pérez', 25, 1, 75, 180, 2),
(13, 'Daniela Gómez', 31, 0, 58, 160, 1),
(14, 'Alejandro Morales', 47, 1, 88, 177, 4),
(15, 'Paula Torres', 37, 0, 65, 168, 2),
(16, 'Mario Hernández', 43, 1, 82, 172, 3),
(17, 'Carmen Ramírez', 30, 0, 53, 158, 4),
(18, 'Ricardo Fernández', 48, 1, 95, 182, 1),
(19, 'Elena Vargas', 26, 0, 57, 161, 2),
(20, 'Andrés López', 39, 1, 79, 176, 3),
(21, 'Isabel Martínez', 34, 0, 63, 167, 1),
(22, 'Miguel Sánchez', 49, 1, 87, 174, 2),
(23, 'Natalia González', 27, 0, 56, 163, 3),
(24, 'Martín Díaz', 44, 1, 84, 179, 4),
(25, 'Lucía Pérez', 32, 0, 62, 166, 1),
(26, 'Javier Castro', 38, 1, 77, 175, 2),
(27, 'Sara Ramírez', 41, 0, 72, 170, 3),
(28, 'Adrián Torres', 53, 1, 89, 178, 4),
(29, 'Marina López', 36, 0, 66, 169, 1),
(30, 'Pedro Martínez', 46, 1, 83, 173, 2),
(31, 'Valeria Sánchez', 23, 0, 52, 159, 3),
(32, 'Roberto González', 51, 1, 91, 181, 4),
(33, 'Camila Díaz', 24, 0, 54, 162, 1),
(34, 'Federico Gómez', 56, 1, 92, 183, 2),
(35, 'Manuela Morales', 21, 0, 49, 154, 3),
(36, 'Joaquín Vargas', 57, 1, 93, 184, 4),
(37, 'Carolina Fernández', 20, 0, 48, 153, 1),
(38, 'Leonardo López', 58, 1, 94, 185, 2),
(39, 'Renata Martínez', 19, 0, 47, 152, 3),
(40, 'Gustavo Sánchez', 59, 1, 95, 186, 4),
(41, 'Alma González', 18, 0, 46, 151, 1),
(42, 'Matías Díaz', 60, 1, 96, 187, 2),
(43, 'Bianca Torres', 29, 0, 60, 162, 3),
(44, 'Emilio Ramírez', 35, 1, 77, 176, 4),
(45, 'Diana Pérez', 26, 0, 57, 161, 1),
(46, 'Julián Martínez', 31, 1, 73, 177, 2),
(47, 'Romina Sánchez', 33, 0, 68, 165, 3),
(48, 'Alexis Rodríguez', 27, 1, 75, 180, 4),
(49, 'Gabriela Vargas', 30, 0, 65, 168, 1),
(50, 'Oscar González', 28, 1, 80, 175, 2);


INSERT INTO doctores (id_doctor, nombre, id_especialidad, id_usuario, id_paciente) VALUES
(1, 'Dr. Pérez', 1, 1, 1),
(2, 'Dra. González', 2, 2, 2),
(3, 'Dr. Martínez', 3, 3, 3),
(4, 'Dra. Rodríguez', 4, 4, 4),
(5, 'Dr. Sánchez', 5, 5, 5),
(6, 'Dra. Ramírez', 6, 6, 6),
(7, 'Dr. López', 7, 7, 7),
(8, 'Dra. Hernández', 8, 8, 8),
(9, 'Dr. Díaz', 9, 9, 9),
(10, 'Dra. Torres', 10, 10, 10),
(11, 'Dr. Castro', 1, 11, 11),
(12, 'Dra. Flores', 2, 12, 12),
(13, 'Dr. Gómez', 3, 13, 13),
(14, 'Dra. Vargas', 4, 14, 14),
(15, 'Dr. Morales', 5, 15, 15),
(16, 'Dra. Silva', 6, 16, 16),
(17, 'Dr. Rivera', 7, 17, 17),
(18, 'Dra. Cruz', 8, 18, 18),
(19, 'Dr. Ríos', 9, 19, 19),
(20, 'Dra. Aguilar', 10, 20, 20),
(21, 'Dr. Reyes', 1, 21, 21),
(22, 'Dra. Jiménez', 2, 22, 22),
(23, 'Dr. Fernández', 3, 23, 23),
(24, 'Dra. Pérez', 4, 24, 24),
(25, 'Dr. González', 5, 25, 25);

INSERT INTO citas (id_cita, fecha, id_doctor) VALUES
(1, '2024-05-10 09:00:00', 1),
(2, '2024-05-10 10:00:00', 2),
(3, '2024-05-11 11:00:00', 3),
(4, '2024-05-11 12:00:00', 4),
(5, '2024-05-12 13:00:00', 5),
(6, '2024-05-12 14:00:00', 6),
(7, '2024-05-13 15:00:00', 7),
(8, '2024-05-13 16:00:00', 8),
(9, '2024-05-14 17:00:00', 9),
(10, '2024-05-14 18:00:00', 10),
(11, '2024-05-15 09:00:00', 11),
(12, '2024-05-15 10:00:00', 12),
(13, '2024-05-16 11:00:00', 13),
(14, '2024-05-16 12:00:00', 14),
(15, '2024-05-17 13:00:00', 15),
(16, '2024-05-17 14:00:00', 16),
(17, '2024-05-18 15:00:00', 17),
(18, '2024-05-18 16:00:00', 18),
(19, '2024-05-19 17:00:00', 19),
(20, '2024-05-19 18:00:00', 20),
(21, '2024-05-20 09:00:00', 21),
(22, '2024-05-20 10:00:00', 22),
(23, '2024-05-21 11:00:00', 23),
(24, '2024-05-21 12:00:00', 24),
(25, '2024-05-22 13:00:00', 25);


INSERT INTO recetas (id_receta, id_paciente, id_doctor, id_medicamento) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5),
(6, 6, 6, 6),
(7, 7, 7, 7),
(8, 8, 8, 8),
(9, 9, 9, 9),
(10, 10, 10, 10),
(11, 11, 11, 11),
(12, 12, 12, 12),
(13, 13, 13, 13),
(14, 14, 14, 14),
(15, 15, 15, 15),
(16, 16, 16, 16),
(17, 17, 17, 17),
(18, 18, 18, 18),
(19, 19, 19, 19),
(20, 20, 20, 20),
(21, 21, 21, 21),
(22, 22, 22, 22),
(23, 23, 23, 23),
(24, 24, 24, 24),
(25, 25, 25, 25);

INSERT INTO enfermeros (id_enfermero, nombre, edad) VALUES
(1, 'Ana López', 30),
(2, 'Carlos García', 35),
(3, 'María Rodríguez', 28),
(4, 'Pedro Martínez', 40),
(5, 'Laura Pérez', 32),
(6, 'Juan Hernández', 38),
(7, 'Carmen Sánchez', 29),
(8, 'Javier González', 36),
(9, 'Sara Díaz', 31),
(10, 'Diego Ruiz', 37),
(11, 'Lucía Torres', 33),
(12, 'Miguel Gómez', 39),
(13, 'Elena Vargas', 34),
(14, 'Luisa Ruiz', 42),
(15, 'Andrés Castro', 27),
(16, 'Marina Flores', 41),
(17, 'Ricardo López', 26),
(18, 'Paula Martínez', 43),
(19, 'Pablo González', 25),
(20, 'Ana María Sánchez', 44),
(21, 'David Pérez', 24),
(22, 'Natalia Ramírez', 45),
(23, 'José Rodríguez', 23),
(24, 'María José Pérez', 46),
(25, 'Francisco González', 22);


INSERT INTO limpieza (id_limpieza, nombre, edad) VALUES
(1, 'María López', 40),
(2, 'Juan Martínez', 45),
(3, 'Ana García', 35),
(4, 'Carlos Rodríguez', 50),
(5, 'Laura Pérez', 32),
(6, 'Luis González', 55),
(7, 'Sofía Hernández', 42),
(8, 'Diego Díaz', 38),
(9, 'Valentina Castro', 29),
(10, 'Gabriel Ramírez', 47),
(11, 'Fernanda Sánchez', 41),
(12, 'José Pérez', 36),
(13, 'Daniela Gómez', 33),
(14, 'Alejandro Morales', 48),
(15, 'Paula Torres', 37),
(16, 'Mario Hernández', 54),
(17, 'Carmen Ramírez', 39),
(18, 'Ricardo Fernández', 49),
(19, 'Elena Vargas', 34),
(20, 'Andrés López', 53),
(21, 'Isabel Martínez', 46),
(22, 'Miguel Sánchez', 52),
(23, 'Natalia González', 43),
(24, 'Martín Díaz', 51),
(25, 'Lucía Pérez', 31);

	INSERT INTO cargo (id_cargo, id_doctor, id_enfermero, id_limpieza) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5),
(6, 6, 6, 6),
(7, 7, 7, 7),
(8, 8, 8, 8),
(9, 9, 9, 9),
(10, 10, 10, 10),
(11, 11, 11, 11),
(12, 12, 12, 12),
(13, 13, 13, 13),
(14, 14, 14, 14),
(15, 15, 15, 15),
(16, 16, 16, 16),
(17, 17, 17, 17),
(18, 18, 18, 18),
(19, 19, 19, 19),
(20, 20, 20, 20),
(21, 21, 21, 21),
(22, 22, 22, 22),
(23, 23, 23, 23),
(24, 24, 24, 24),
(25, 25, 25, 25);

INSERT INTO empleados (id_empleado, nombre, edad, id_cargo, id_sucursal) VALUES
(1, 'Juan Pérez', 30, 1, 1),
(2, 'María García', 35, 2, 2),
(3, 'Pedro López', 28, 3, 3),
(4, 'Ana Martínez', 40, 4, 4),
(5, 'Carlos Hernández', 32, 5, 5),
(6, 'Laura Rodríguez', 28, 6, 1),
(7, 'Luisa Sánchez', 35, 7, 2),
(8, 'José González', 33, 8, 3),
(9, 'Sara Díaz', 38, 9, 4),
(10, 'David Torres', 31, 10, 5),
(11, 'Lucía Ramírez', 29, 11, 1),
(12, 'Javier Ruiz', 36, 12, 2),
(13, 'Fernando Vargas', 34, 13, 3),
(14, 'Paula Castro', 39, 14, 4),
(15, 'Miguel Flores', 30, 15, 5),
(16, 'Carla Pérez', 27, 16, 1),
(17, 'Andrea García', 37, 17, 2),
(18, 'Mario López', 33, 18, 3),
(19, 'Elena Martínez', 40, 19, 4),
(20, 'Jorge Hernández', 31, 20, 5),
(21, 'Marina Rodríguez', 28, 21, 1),
(22, 'Gabriel Sánchez', 35, 22, 2),
(23, 'Natalia González', 32, 23, 3),
(24, 'Daniel Pérez', 38, 24, 4),
(25, 'Sofía Martínez', 29, 25, 5);

INSERT INTO farmacia (id_farmacia, id_empleado, id_receta) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5),
(6, 6, 6),
(7, 7, 7),
(8, 8, 8),
(9, 9, 9),
(10, 10, 10),
(11, 11, 11),
(12, 12, 12),
(13, 13, 13),
(14, 14, 14),
(15, 15, 15),
(16, 16, 16),
(17, 17, 17),
(18, 18, 18),
(19, 19, 19),
(20, 20, 20),
(21, 21, 21),
(22, 22, 22),
(23, 23, 23),
(24, 24, 24),
(25, 25, 25);

INSERT INTO planilla (id_planilla, salario_base, renta, seguro, salario_neto, fecha_pago, numero_cuenta, id_empleado) VALUES
(1, 2000.00, 200.00, 50.00, 1750.00, '2023-01-25 09:00:00', 100001, 1),
(2, 2100.00, 210.00, 52.50, 1837.50, '2023-02-25 09:00:00', 100002, 2),
(3, 2200.00, 220.00, 55.00, 1925.00, '2023-03-25 09:00:00', 100003, 3),
(4, 2300.00, 230.00, 57.50, 2012.50, '2023-04-25 09:00:00', 100004, 4),
(5, 2400.00, 240.00, 60.00, 2100.00, '2023-05-25 09:00:00', 100005, 5),
(6, 2500.00, 250.00, 62.50, 2187.50, '2023-06-25 09:00:00', 100006, 6),
(7, 2600.00, 260.00, 65.00, 2275.00, '2023-07-25 09:00:00', 100007, 7),
(8, 2700.00, 270.00, 67.50, 2362.50, '2023-08-25 09:00:00', 100008, 8),
(9, 2800.00, 280.00, 70.00, 2450.00, '2023-09-25 09:00:00', 100009, 9),
(10, 2900.00, 290.00, 72.50, 2537.50, '2023-10-25 09:00:00', 100010, 10),
(11, 3000.00, 300.00, 75.00, 2625.00, '2023-11-25 09:00:00', 100011, 11),
(12, 3100.00, 310.00, 77.50, 2712.50, '2023-12-25 09:00:00', 100012, 12),
(13, 3200.00, 320.00, 80.00, 2800.00, '2024-01-25 09:00:00', 100013, 13),
(14, 3300.00, 330.00, 82.50, 2887.50, '2024-02-25 09:00:00', 100014, 14),
(15, 3400.00, 340.00, 85.00, 2975.00, '2024-03-25 09:00:00', 100015, 15),
(16, 3500.00, 350.00, 87.50, 3062.50, '2024-04-25 09:00:00', 100016, 16),
(17, 3600.00, 360.00, 90.00, 3150.00, '2024-05-25 09:00:00', 100017, 17),
(18, 3700.00, 370.00, 92.50, 3237.50, '2024-06-25 09:00:00', 100018, 18),
(19, 3800.00, 380.00, 95.00, 3325.00, '2024-07-25 09:00:00', 100019, 19),
(20, 3900.00, 390.00, 97.50, 3412.50, '2024-08-25 09:00:00', 100020, 20),
(21, 4000.00, 400.00, 100.00, 3500.00, '2024-09-25 09:00:00', 100021, 21),
(22, 4100.00, 410.00, 102.50, 3587.50, '2024-10-25 09:00:00', 100022, 22),
(23, 4200.00, 420.00, 105.00, 3675.00, '2024-11-25 09:00:00', 100023, 23),
(24, 4300.00, 430.00, 107.50, 3762.50, '2024-12-25 09:00:00', 100024, 24),
(25, 4400.00, 440.00, 110.00, 3850.00, '2025-01-25 09:00:00', 100025, 25);


