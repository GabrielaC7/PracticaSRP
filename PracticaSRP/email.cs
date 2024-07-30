public class EmailService
{
    public void EnviarCorreoElectronico(string direccion, string mensaje)
    {
        Console.WriteLine($"Enviando correo a {direccion}: {mensaje}");
    }
}