namespace ClinicaAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Diagnostico { get; set; } = string.Empty;

        // NUEVOS CAMPOS
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

    }
}
