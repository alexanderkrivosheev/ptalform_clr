namespace ptalform_clr.csharp_12.primary_constructor
{
    internal class ClassA(string firstName, string secondName)
    {

        /// <summary>
        /// Every other constructor for a class must call the primary constructor
        /// </summary>
        public ClassA() : this("", "")
        {

        }


        /// <summary>
        /// primary constructor and  readonly parameters
        /// </summary>
        private readonly string firstName;
        private readonly string secondName;

        /// <summary>
        /// primay constructor parameters and properties
        /// To initialize a member field or property.
        /// </summary>
        public string FirstName => firstName;
        public string SecondName => secondName;

        public override string ToString()
        {
            return firstName + secondName;
        }
    }

    internal class ClassB(string firstName, string secondName)
    {

        public ClassB() : this("", "")
        {
          
        }


        public override string ToString()
        {
            //this.firstName = ""; can't be accessed as this.param.
            return firstName + secondName;
        } 
    }

    internal class ClassС(string firstName, string secondName): ClassB("","")
    {
        public override string ToString()
        {
            //this.firstName = ""; can't be accessed as this.param.
            return firstName + secondName;
        }
    }

    internal class StructA(string firstName, string secondName)
    {

        public StructA() : this("", "")
        {
            
        }

        /// <summary>
        /// primary constructor and  readonly parameters
        /// </summary>
        private readonly string firstName;
        private readonly string secondName;

        /// <summary>
        /// primay constructor parameters and properties
        /// </summary>
        public string FirstName => firstName;
        public string SecondName => secondName;

        public override string ToString()
        {
            return firstName + secondName;
        }
    }
}
