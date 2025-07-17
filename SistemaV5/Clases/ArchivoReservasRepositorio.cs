using sistemaDeViajesV3.Clases;
using sistemaDeViajesV3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV5.Clases
{
    public class ArchivoReservasRepositorio : IReservasRepositorio
    {
        private readonly string _filePath = "reservas.txt";

        public void AddReserva(CLSReserva reserva)
        {
            throw new NotImplementedException();
        }

        public List<CLSReserva> GetAllReservas()
        {
            List<CLSReserva> listareservas = new List<CLSReserva>();
            listareservas.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {

                    sr.ReadLine();

                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        string[] vec = linea.Split(',');

                        CLSReserva reserva = new CLSReserva();

                        reserva = reserva.FromString(linea);

                        const int ExpectedFields = 9;
                        if (vec.Length < ExpectedFields)
                        {
                            Console.WriteLine($"Advertencia (FileReservaRepository): Línea de reserva incompleta o incorrecta (se esperaban {ExpectedFields} campos, se encontraron {vec.Length}): '{linea}'. Saltando esta línea.");
                            continue;
                        }

                        listareservas.Add(reserva);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar reservas desde el archivo: {ex.Message}", ex);
            }
            return listareservas;
        }
    }
}
