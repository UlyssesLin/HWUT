using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System.Text.Json;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        // ProductModel instance should not be null after initialization
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        // Tests get and set for Id
        [TestMethod]
        public void ProductModel_Set_Id_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "earphone1";

            // Assert
            Assert.AreEqual("earphone1", result.Id);
        }

        // Tests get and set for Maker
        [TestMethod]
        public void ProductModel_Set_Maker_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "Peter Loyd";

            // Assert
            Assert.AreEqual("Peter Loyd", result.Maker);
        }

        // Tests get and set for Image
        [TestMethod]
        public void ProductModel_Set_Image_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "./img/earphone1.png";

            // Assert
            Assert.AreEqual("./img/earphone1.png", result.Image);
        }

        // Tests get and set for Url
        [TestMethod]
        public void ProductModel_Set_Url_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "TourStart";

            // Assert
            Assert.AreEqual("TourStart", result.Url);
        }

        // Tests get and set for Title
        [TestMethod]
        public void ProductModel_Set_Title_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Seattle U, a pretty Campus";

            // Assert
            Assert.AreEqual("Seattle U, a pretty Campus", result.Title);
        }

        // Tests get and set for Description
        [TestMethod]
        public void ProductModel_Set_Description_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "fantastic";

            // Assert
            Assert.AreEqual("fantastic", result.Description);
        }

        // Default Date should be initialized to Now
        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        // Get and set Sequence results should be the same
        [TestMethod]
        public void ProductModel_Set_Sequence_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "TourStart2";

            // Assert
            Assert.AreEqual("TourStart2", result.Sequence);
        }

        // Default Email should be initialized to "Unknown"
        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        // Get and set Logistics results should be the same
        [TestMethod]
        public void ProductModel_Set_Logistics_String_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "I will pickup";

            // Assert
            Assert.AreEqual("I will pickup", result.Logistics);
        }

        // Default Ratings should be initialized to an array with just one index, value 5
        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.Ratings[0]);
        }

        // Default instance ToString() should result in a string
        [TestMethod]
        public void ProductModel_ToString_Default_Should_Be_String()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsInstanceOfType(result.ToString(), typeof(string));
        }

        // Default instance ToString() should be stringified version of the .json
        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(JsonSerializer.Serialize<ProductModel>(result), result.ToString());
        }

        // Default instance AverageRating should be 5
        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        // AverageRating of null Ratings should be 0
        [TestMethod]
        public void ProductModel_AverageRating_Null_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        // AverageRating of empty Ratings should be 0
        [TestMethod]
        public void ProductModel_AverageRating_No_Ratings_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        // AverageRating of all 0 Ratings (total = 0) should be 0
        [TestMethod]
        public void ProductModel_AverageRating_All_Ratings_0_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { 0, 0, 0, 0 };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }
    }
}
