using System;
using System.Collections;
using NUnit.Framework;

namespace OpenAI_Tests
{
    [TestFixture]
    public class GetEnvVars
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void GetAllVars()
        {
            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User))
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
        }
    }
}