Inventory Manager for Wig Salon

A desktop management system for wig salons, designed to streamline daily operations such as inventory tracking, customer management, appointments, sales, and repairs.

This project was developed throughout 2024 as a high school final project in the computer science track. It was created for a real working wig salon to make daily data handling easier, faster, and more reliable.

Technologies used:

* WPF (C# and XAML)
* WCF Services
* SQL Server LocalDB
* Entity Framework

Main features:

* Manage wigs, customers, sales, appointments, and repairs
* Easily search across the system by client, wig, date, or worker
* Clean and intuitive interface for salon admins

Screenshots and Descriptions:

**HomePage**
The main navigation screen of the application. From here, the user can access all major parts of the system: Customers, Wigs, Appointments, Repairs, Sales, and Settings.

![HomePage](https://github.com/noa4970/inventory-manager/blob/main/HomePage.png)

**CustomersListPage**
Displays a list of all customers with a search bar for filtering by first or last name. Selecting a customer leads to their detailed profile. Includes a button to add a new customer.

![CustomersListPage](https://github.com/noa4970/inventory-manager/blob/main/CustomersListPage.png)

**AddCustomerPage**
Form for entering a new customer's first name, last name, and phone number. After confirmation, options appear to add an appointment or a new wig purchase.

![AddCustomerPage](https://github.com/noa4970/inventory-manager/blob/main/AddCustomerPage.png)

**WigsListPage**
Searchable table of all wigs in the system. Selecting a wig shows its full details. Includes a button for adding a new wig.

![WigsListPage](https://github.com/noa4970/inventory-manager/blob/main/WigsListPage.png)

**AppointmentsListPage**
A table view of all appointments in the system. Filterable by customer name, date, or worker. Each row is clickable for more details. Includes an "Add appointment" button.

![AppointmentsListPage](https://github.com/noa4970/inventory-manager/blob/main/AppointmentsListPage.png)

Note:
This was built as a standalone Windows application and is not currently set up for external deployment.
