# MiniTaskApp

- Usuario
Id int
Nombre string

- Tarea
Id int
Titulo string
Descripcion string
Asignados List<Usuario>

- Grupos
Id
Miembros List<Usuario>
Tareas List<Tarea>