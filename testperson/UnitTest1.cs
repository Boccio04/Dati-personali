namespace TestPerson
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestConstructors()
        {
            //declare variable
            personClass.Person myPerson;

            //test parametless constructor
            myPerson = new personClass.Person();

            //test constructor
            myPerson = new personClass.Person("Andrea", "Bocedi");

            //test constructor
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.Male);

            //test constructor
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.Male, "Sassuolo", new DateTime(1991, 11, 25));

            //test constructor
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.Male, "Sassuolo", "MO", new DateTime(1991, 11, 25));
        }

        [TestMethod]
        public void TestFiscalCode()
        {
            //declare variable
            personClass.Person myPerson;

            //test normal case
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.Male, "Sassuolo", "MO", new DateTime(1991, 11, 25));

            if (myPerson.FiscalCode() != "BCDNDR91S25I462T")
            {
                throw new Exception("Wrong fiscal code!");
            }

            //test gender not specified
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.NotSpecified, "Sassuolo", "MO", new DateTime(1991, 11, 25));

            if (myPerson.FiscalCode() != "")
            {
                throw new Exception("Wrong fiscal code!");
            }
        }

        [TestMethod]
        public void TestAge()
        {
            //declare variable
            personClass.Person myPerson;

            //test normal case
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.Male, "Sassuolo", "MO", new DateTime(2000, 8, 25));

            if (myPerson.Age() != 23 )
            {
                throw new Exception("Wrong Age!");
            }

            //test birthday not reached
            myPerson = new personClass.Person("Andrea", "Bocedi", personClass.Person.GenderType.NotSpecified, "Sassuolo", "MO", new DateTime(2000, 11, 25));

            if (myPerson.Age() != 22)
            if (myPerson.Age() != 22)
            {
                throw new Exception("Wrong Age!");
            }

        }
    }
}