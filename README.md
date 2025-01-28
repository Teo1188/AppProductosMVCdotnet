## Proyecto MVC - CRUD de Productos

**_Descripción del Proyecto_**

Este proyecto es un ejercicio de implementación de un CRUD (“Create, Read, Update, Delete”) utilizando el patrón de diseño Modelo-Vista-Controlador (MVC). El objetivo es proporcionar una aplicación funcional donde se gestionen productos mediante una interfaz web sencilla.

La aplicación está diseñada para trabajar con una base de datos en memoria utilizando Microsoft Entity Framework Core, lo que facilita la persistencia de los datos durante la sesión de la aplicación.

**_Funcionalidades_**

El proyecto se desarrolla principalmente en la pestaña llamada Productos. Las funcionalidades principales son:

**1. Agregar Productos**

La aplicación permite agregar nuevos productos mediante un formulario.

Los datos requeridos son:

_Nombre_

_Descripción_

_Precio (solo números enteros, no se permiten decimales)._

_Categoría_

Al enviar el formulario, el producto se almacena en la base de datos en memoria.

**2. Visualizar Productos**

Una tabla lista todos los productos agregados con sus respectivas propiedades:

_Id_

_Nombre_

_Descripción_

_Precio_

_Categoría_

**3. Actualizar Productos**

Cada producto en la tabla tiene un botón verde ("Editar") que permite actualizar sus propiedades.

Al hacer clic, se redirige a un formulario prellenado con los datos actuales del producto para realizar los cambios deseados.

Una vez enviados los cambios, se actualizan los datos en la base de datos en memoria.

**4. Eliminar Productos**

Cada producto también tiene un botón rojo ("Eliminar") que permite borrar el producto.

Al hacer clic, el producto es eliminado permanentemente de la base de datos en memoria.

## Tecnologías Utilizadas

ASP.NET Core MVC: Framework para la implementación del patrón MVC.

Entity Framework Core: Para la gestión de la base de datos en memoria.

Bootstrap: Para diseño y estilos en la interfaz.

C#: Lenguaje de programación principal del proyecto.
 

**Cómo Ejecutar el Proyecto**

Clona este repositorio en tu máquina local:

```bash
git clone https://github.com/Teo1188/AppProductosMVCdotnet.git
```

Abre el proyecto en un entorno compatible, como Visual Studio.

**Ejecuta la aplicación:**

Selecciona la opción Ejecutar o presiona F5.

Accede a la aplicación desde tu navegador en la ruta:

https://localhost:<puerto>/Productos

**Nota Final**

Este proyecto es una base para aprender y practicar conceptos fundamentales de aplicaciones web utilizando el patrón MVC. La base de datos en memoria es ideal para pruebas, pero no es adecuada para entornos de producción.
