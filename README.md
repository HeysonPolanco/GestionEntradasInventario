# Sistema de Gestión de Entradas de Inventario

## Descripción
El objetivo de esta asignación es desarrollar un portal web robusto para la gestión de 
productos y el control de sus entradas al almacén. El estudiante deberá demostrar dominio en 
el manejo de relaciones Maestro-Detalle, integridad de datos transaccional y seguridad 
básica. 
El sistema debe permitir crear productos y registrar entradas de mercancía, asegurando que 
el Inventario se actualice de manera automática y consistente.

## Tecnologías utilizadas
- Blazor Server (.NET 10)
- ASP.NET Core Identity
- Entity Framework Core (Code First)
- SQL Server (Azure SQL Database)
- Azure App Service

## Funcionalidades implementadas

### Productos
- Registro, edición y eliminación
- Validaciones de campos
- Listado con filtros

### Entradas de productos
- Registro Maestro–Detalle
- Cálculo automático del total
- Actualización automática del inventario

### Lógica de inventario
- Suma al crear entradas
- Reversión y actualización al editar
- Reversión total al eliminar

### Seguridad
- Registro y autenticación de usuarios
- Acceso restringido a usuarios autenticados

## Aplicación publicada
gestionentradasinventario-bpaug8f3grdcb8fk.eastus2-01.azurewebsites.net 

## Repositorio
https://github.com/YudelkaTorres/GestionEntradasInventario.git 

