namespace BancaMovil.Models
{
    /// <summary>
    /// Clase que representa un usuario del sistema de banca móvil
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador único del usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre completo del usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Email único del usuario
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contraseña del usuario (en producción debería estar hasheada)
        /// </summary>
        public string Contrasena { get; set; }

        /// <summary>
        /// Fecha de creación de la cuenta
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Constructor del usuario
        /// </summary>
        public Usuario(int id, string nombre, string email, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
            FechaRegistro = DateTime.Now;
        }

        /// <summary>
        /// Obtiene la información del usuario de forma legible
        /// </summary>
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Email: {Email}, Registrado: {FechaRegistro:dd/MM/yyyy}";
        }
    }
}
