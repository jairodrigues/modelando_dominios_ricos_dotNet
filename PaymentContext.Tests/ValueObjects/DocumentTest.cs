using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
			var doc = new Document("123", EDocumentType.CNPJ);
			Assert.IsTrue(doc.Invalid);
        }

		[TestMethod]
        public void ShouldReturnErrorWhenCNPJIsValid()
        {
			var doc = new Document("28495518000162", EDocumentType.CNPJ);
			Assert.IsTrue(doc.Valid);
        }

		[TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
			var doc = new Document("123456", EDocumentType.CPF);
			Assert.IsTrue(doc.Invalid);
        }

		[TestMethod]
		[DataTestMethod]
		[DataRow("03845006099")]
		[DataRow("97880512004")]
        public void ShouldReturnErrorWhenCPFIsValid(string cpf)
        {
			var doc = new Document(cpf, EDocumentType.CPF);
			Assert.IsTrue(doc.Valid);
        }
    }
}
