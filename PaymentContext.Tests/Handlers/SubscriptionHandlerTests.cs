using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
	[TestClass]
	public class SubscriptionHandlerTest
	{
		[TestMethod]
		public void ShouldReturnErrorWhenDocumentExists()
		{
			var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
			var command = new CreateBoletoSubscriptionCommand();
			command.FirstName = "Bruce";
			command.LastName = "Wayne";
			command.Document = "99999999999";
			command.Email = "hello@balta.com";
			command.BarCode = "123456789";
			command.BoletoNumber = "1234654987";
			command.PaymentNumber = "123121";
			command.PaidDate = DateTime.Now;
			command.ExpireDate = DateTime.Now.AddMonths(1);
			command.Total = 60;
			command.TotalPaid = 60;
			command.Payer = "WAYNE CORP";
			command.PayerDocument = "12345678911";
			command.PayerDocumentType = EDocumentType.CPF;
			command.PayerEmail = "batman@dc.com";
			command.Street = "ef dsf";
			command.Number = "sdfsdfsdf";
			command.Neighborhood = "asdfdsf sdfsfsasd";
			command.City = "assdfsd";
			command.State = "adfsds";
			command.Country = "dsfsdas";
			command.ZipCode = "10239485";

			handler.Handle(command);
			Assert.AreEqual(false, handler.Valid);
		}
	}
}