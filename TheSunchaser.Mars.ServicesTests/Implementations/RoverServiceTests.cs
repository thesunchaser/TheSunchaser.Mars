using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheSunchaser.Mars.Domain.Interfaces;
using TheSunchaser.Mars.Services.Interfaces;
using TheSunchaser.Mars.Domain.Parsers;
using TheSunchaser.Mars.Domain.Factories;
using System;

namespace TheSunchaser.Mars.Services.Tests
{
    [TestClass()]
    public class RoverServiceTests
    {
        [TestMethod()]
        public void ParseInputTest()
        {

            string input = $"5 5{Environment.NewLine}1 2 N{Environment.NewLine}LMLMLMLMM{Environment.NewLine}3 3 E{Environment.NewLine}MMRMMRMRRM{Environment.NewLine}";
            string output = string.Empty;
            string expectedOutput = $"1 3 N{Environment.NewLine}5 1 E{Environment.NewLine}";

            //poor man's dependency injection 
            IInstructionParser parser = new InstructionParser();
            IRoverFactory factory = new RoverFactory();
            IRoverService service = new RoverService(factory, parser);

            var response = service.ParseInput(new Domain.Parser.Messages.ExecuteRequest() { Input = input });

            //if no exceptions encountered
            if (response.Exception == null)
            {
                //get the output
                output = response.Output;
            }
            else
            {
                output = response.Exception.Message;
            }

            Console.WriteLine(output);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}