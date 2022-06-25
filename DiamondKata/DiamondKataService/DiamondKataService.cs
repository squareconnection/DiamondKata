using System;

namespace DiamondKata.Services
{
    public class DiamondKataService
    {
        public string Execute(string character)
        {
            if(character=="A"){
                return "A";
            }
            throw new NotImplementedException("Not full implemented");
        }
    }
}
