using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSunchaser.Mars.Common.Extensions;
using TheSunchaser.Mars.Domain.Entities;
using TheSunchaser.Mars.Domain.Exceptions;
using TheSunchaser.Mars.Domain.Interfaces;
using TheSunchaser.Mars.Domain.Parser.Messages;
using TheSunchaser.Mars.Services.Interfaces;

namespace TheSunchaser.Mars.Services
{
    public class RoverService : IRoverService
    {
        private IRoverFactory _roverFactory;
        private IInstructionParser _parser;

        public RoverService(IRoverFactory roverFactory, IInstructionParser parser)
        {
            _roverFactory = roverFactory;
            _parser = parser;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ExecuteResponse ParseInput(ExecuteRequest request)
        {
            ExecuteResponse resp = new ExecuteResponse();
            if (!string.IsNullOrEmpty(request.Input))
            {
                List<string> lines = request.Input.Split(new[] { Environment.NewLine },StringSplitOptions.RemoveEmptyEntries).ToList();

                //assumption: 5 lines of input
                //1st line is upper bound of landing area
                // 2nd = deployment position of rover 1
                // 3rd = instructions of rover 1
                // 4th line = deployment position of rover 2
                // 5th line = instructions of rover 2
                if (lines.Any())
                {
                    try
                    {
                        Plateau p = GetPlateau(lines.First());

                        var splitRoversList = lines.SplitList(2, 1).ToList();

                        for (int i = 0; i < splitRoversList.Count; i++)
                        {
                            var deployment = splitRoversList[i][0];
                            var rover = _roverFactory.GetRover(splitRoversList[i][0]).SetName($"Rover{i}");
                            rover.Execute(p, _parser.Parse(splitRoversList[i][1]));

                            resp.Output += $"{rover.Position.XCoordinate} {rover.Position.YCoordinate} {rover.Orientation}{Environment.NewLine}";
                        }
                     
                    }
                    catch (ParserException)
                    {
                        throw;
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException($"Unhandled exception encountered with message {ex.Message}" ,ex);
                    }
                }
            }
            return resp;
        }

        /// <summary>
        /// Returns the Landing Plateau coordinates based on the string input
        /// </summary>
        /// <param name="input"></param>
        private Plateau GetPlateau(string input)
        {
            var plateau = new Plateau();
            var instructions = input.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            if (instructions.Length == 2)
            {
                plateau.LowerBound = new Position { XCoordinate = 0, YCoordinate = 0 };
                plateau.UpperBound = new Position { XCoordinate = int.Parse(instructions[0]), YCoordinate = int.Parse(instructions[1]) };
            }
            else
            {
                throw new Exception("Expecting two input integer values for upper right coordinates.");
            }

            return plateau;
        }       
    }
}
