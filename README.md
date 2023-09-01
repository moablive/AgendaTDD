# AgendaTDD
.NET FRAMEWORK


SLQXPRESS
SSMS + SQL Server Management Studio

Agenda.DALL.Test 

app.config
<connectionStrings>
		<add name="con" connectionString="Data Source=.\sqlexpress;Initial Catalog=Agenda;Integrated Security=True;" />
</connectionStrings>


--COAMANDOS PARA CRIAR

Create database Agenda
go
use Agenda
go
create table Contato
(
	ID uniqueidentifier primary key,
	Nome varchar(100)
)


--COMANDOS PARA LIMPAR

use Agenda
go
SELECT * FROM dbo.Contato;
go
DELETE FROM dbo.Contato;
