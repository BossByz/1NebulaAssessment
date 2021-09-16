1) There are a couple of improvements that can be implemented to make this basic ERD better.

- The primary key EmployeeGUID should reference a foreign key in the Event Detail Table as this can keep track of exactly what employee each event is dealing with. 

- The foreign key Cellphone Number has a zero-to-many relationship, meaning the foreign key could be null, which would make it almost impossible to identify which employee was involved with the current event entry.

- Vendor seems to be duplicated, which is not necessary if the Vendor in the event detail table matches the Vendor in the employee table. This can be overcome by removing the vendor field from the event detail table and using EmployeeGUID as a foreign key to identify the vendor from the even detail table.

- There is no required indication, meaning fields can be null which can cause serious problems down the line.