using HelloWorld2;
using System;
using System.IO;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Main_OutputName()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("Scott"))
                {
                    Console.SetIn(sr);

                    Program.Main();
                }

                var result = sw.ToString().Replace("Please enter your name: ", "").Replace(Environment.NewLine, "");

                Assert.StartsWith("Hello ", result);
                Assert.EndsWith("!", result);
                Assert.True(result.Length > "Hello !".Length);
            }
        }
    }
}
