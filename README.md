# 060_PermisionBasedAuthorization

- Permission-Based Authorization in ASP.NET Core – Complete User Management Guide in .NET 5
	- https://codewithmukesh.com/blog/permission-based-authorization-in-aspnet-core/
		
		- Agregar proyecto ASP.NET Core Web app (Model-View-Controller)
		- Add git ignore files.
		- Change Default Connection Strings
		- In Package Manager Console run: "Update-Database"
		- Add service for IdentityUser and IdentityRole
		- Pre-Defined Roles and Users
			- Add Constants folder
			- Add enum Roles
			- Add permissions class
		- Seeding Users and Roles
			- Add Seeds folder
			- Add DefaultRoles
			- Add DefaultUsers
			- Modify Main method to seed database
		- Displaying a List of Registered Users
			- Add UsersController
			- Add Index view.
			- Test it: localhost:44389/Users
		- Role Management UI
			- Add RolesController
			- Add Index view.
			- Test it: localhost:44389/Roles
		
