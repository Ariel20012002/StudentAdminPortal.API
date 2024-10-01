using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        // Propiedades de Navegacion
        public Guid StudentId { get; set; }
    }
}
