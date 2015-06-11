# PayrollApp
Hi,

Although this is fairly simple program but I have tried to demonstrate best practices.

I have developed a multi-layer application called “Payroll”. IOC (Inversion of Control) and DI (dependency Injection) techniques are used across all the layers using structure map. I have also used Entityframework 6.1 as ORM tool.

Screenshot of Console program is provided. Sql query for Task 1 is provided in a separate text file along with Result screenshot.

Visual Studio Solution File: (PayrollSystem.SLN)

Detail of different layers/projects are as follow:

PayrollSystemConsole: 
---------------------
	Starting project

Payroll.Application:
--------------------
This Service Layer, Implemented using factory Design Pattern. Responsible to provide unit of functionalities to Presentation Layer in our case PayrollSystemConsole project).

Payroll.Common:
---------------
Contains logical Model objects used by the factories in application layer. These are kind of view model that factories return to Presentation layer after mappings them to entity objects.

Payroll.Data:
-------------
This layer contains repositories that provide entity data to application/service layer (Payroll.Application). This layer is implemented using Repository pattern.

Payroll.DataModel:
------------------
Contains the entity Data model. These entities are based on database schema and can be seen visually on double clicking on “PayrolModel.edmx”

Payroll.Domain:
---------------
This contains Entity classes (like Employee, Salary etc) generated through Entity data model. Expand the PayrollModel.tt to explore this classes.

TDD:
----
To support TDD i heavily used interfaces. However, due to time contraint I'm not able to demenstrate TDD technique. But just for an idea each layer would have TDD project associate with it.

Thanks
Muhammad Nauman.
