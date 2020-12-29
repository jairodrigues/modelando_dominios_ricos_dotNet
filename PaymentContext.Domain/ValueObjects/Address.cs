using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {

        public Address(string street, string number, string neighborhood, string city, string state, string contry, string zipCode)
        {
            street = Street;
            number = Number;
            neighborhood = Neighborhood;
            city = City;
            state = State;
            contry = Contry;
            zipCode = ZipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Addres.Street", "A rua deve conter pelo menos 3 caracteres")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Contry { get; private set; }
        public string ZipCode { get; private set; }
    }
}