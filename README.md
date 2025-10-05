# Assignment 2 – CRUD ASP.NET MVC

Student: <Khushi Khushi>
Repo: https://github.com/<khushikhushi>/<COMP2084Assignment2>
Live Site: https://FitnessTrackingApplication.azurewebsites.net

## Purpose
Simple ASP.NET Core MVC app demonstrating CRUD functionality with Products and Categories.

## Setup / How to run locally
1. Update `appsettings.json` with `DefaultConnection`.
2. From project root: `dotnet ef database update`
3. Run: `dotnet run`

## Database
Azure SQL database: <gc200624654>, <gc20050905>
(DB credentials: created in Azure Portal)

## Controllers and Views
- ProductsController (Empty controller created by me, full CRUD implemented)
- CategoriesController (Empty controller created by me, full CRUD implemented)
Razor Views created for Index/Create/Edit/Delete.

## Version Control
Commits (example):
- 2025-09-20: initial project and models
- 2025-09-21: add DbContext and migrations
- 2025-09-22: add ProductsController + Views
- 2025-09-23: add CategoriesController + publish to Azure

## Bonus
(If you added one) Example: Implemented server-side paging with `Skip`/`Take` in Index (document code location).

## Notes
- I invited the instructor (GitHub username: ifotn) as collaborator.
- Live link: https://<FitnessTrackingApplication>.azurewebsites.net
