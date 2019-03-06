namespace Agenda_WPF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        [Key]
        public int idAppointment { get; set; }

        public DateTime? DateHour { get; set; }

        public int idBroker { get; set; }

        public int idCustomer { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
