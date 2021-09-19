use provisional;

Create Table Reportes (
idReporte int NOT NULL,
PRIMARY KEY (idReporte),
nombreReporte varchar(20) NOT NULL,
rutaReporte varchar(100) NOT NULL,
Departamento varchar(20) NOT NULL,
estado boolean NOT NULL
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

INSERT INTO provisional (idReporte, nombreReporte, rutaReporte, Departamento, estado) 
VALUES (1, 'Pagos agosto','C:\Users\alvar\source\repos\Report\VistaReport\bin\Debug','Bancos', 1);

UPDATE reportes set nombreReporte='tarea', rutaReporte='C:\Users\alvar\source\repos', Departamento='progra', estado=1 where idReporte=1