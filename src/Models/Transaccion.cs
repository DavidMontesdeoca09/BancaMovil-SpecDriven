namespace BancaMovil.Models
{
    /// <summary>
    /// Enumeración para los tipos de transacción disponibles
    /// </summary>
    public enum TipoTransaccion
    {
        Deposito,
        Retiro,
        Transferencia,
        Pago
    }

    /// <summary>
    /// Clase que representa una transacción en el sistema
    /// </summary>
    public class Transaccion
    {
        /// <summary>
        /// Identificador único de la transacción
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de transacción realizada
        /// </summary>
        public TipoTransaccion Tipo { get; set; }

        /// <summary>
        /// Monto de la transacción
        /// </summary>
        public decimal Monto { get; set; }

        /// <summary>
        /// Fecha y hora de la transacción
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Descripción de la transacción
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// ID de la cuenta origen
        /// </summary>
        public int CuentaOrigenId { get; set; }

        /// <summary>
        /// ID de la cuenta destino (en caso de transferencia)
        /// </summary>
        public int? CuentaDestinoId { get; set; }

        /// <summary>
        /// Saldo anterior a la transacción
        /// </summary>
        public decimal SaldoAnterior { get; set; }

        /// <summary>
        /// Saldo posterior a la transacción
        /// </summary>
        public decimal SaldoPosterior { get; set; }

        /// <summary>
        /// Constructor de la transacción
        /// </summary>
        public Transaccion(int id, TipoTransaccion tipo, decimal monto, string descripcion, 
                          int cuentaOrigenId, int? cuentaDestinoId, decimal saldoAnterior, decimal saldoPosterior)
        {
            Id = id;
            Tipo = tipo;
            Monto = monto;
            Descripcion = descripcion;
            CuentaOrigenId = cuentaOrigenId;
            CuentaDestinoId = cuentaDestinoId;
            Fecha = DateTime.Now;
            SaldoAnterior = saldoAnterior;
            SaldoPosterior = saldoPosterior;
        }

        /// <summary>
        /// Obtiene la información de la transacción de forma legible
        /// </summary>
        public override string ToString()
        {
            return $"[{Fecha:dd/MM/yyyy HH:mm}] {Tipo}: ${Monto:F2} - {Descripcion} | Saldo: ${SaldoAnterior:F2} → ${SaldoPosterior:F2}";
        }
    }
}
