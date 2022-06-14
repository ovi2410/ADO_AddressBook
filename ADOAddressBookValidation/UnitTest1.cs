using ADO_AddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2_insertintotableusingSP;

namespace uc5_TestProject1
{
    [TestClass]
    public class AddressBookTesting
    {
        ADO_AddressBook.AddressBookRespitory addressBookRepository;
        [TestInitialize]
        public void SetUp()
        {
            addressBookRepository = new ADO_AddressBook.AddressBookRespitory();
        }

        //Usecase 2:Ability to insert new Contacts to Address Book
        [TestMethod]
        public void TestMethodInsertIntoTable()
        {
            int expected = 1;
            ContactDataManager addressBook = new ContactDataManager();
            addressBook.FirstName = "Rani";
            addressBook.LastName = "Malvi";
            addressBook.Address = "Baker's Street";
            addressBook.City = "Chennai";
            addressBook.State = "TamilNadu";
            addressBook.zip = 243022;
            addressBook.PhoneNumber = 9842905050;
            addressBook.Email = "rani@gmail.com";
            addressBook.AddressBookName = "FriendName";
            addressBook.Type = "Friends";
            int actual = addressBookRepository.InsertIntoTable(addressBook);
            Assert.AreEqual(expected, actual);
        }
        //UseCase 3: Modify Existing Contact using their name
        [TestMethod]
        public void GivenUpdateQuery_ReturnOne()
        {
            int expected = 1;
            int actual = addressBookRepository.UpdateQueryBasedonName();
            Assert.AreEqual(expected, actual);
        }
        //UseCase 4: Delete person based on Name
        [TestMethod]
        public void GivenDeleteQuery_ReturnOne()
        {
            int expected = 1;
            int actual = addressBookRepository.DeletePersonBasedonName();
            Assert.AreEqual(expected, actual);
        }
        //UseCase 5: Ability to Retrieve Person belonging to a City or State from the Address Book
        [TestMethod]
        public void GivenRetrieveQuery_ReturnString()
        {
            string expected = "Harsha Pramela meena ";
            string actual = addressBookRepository.PrintDataBasedOnCity("Bangalore", "Karnataka");
            Assert.AreEqual(expected, actual);
        }
    }
}