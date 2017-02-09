using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarWords.Services.WordCalculatorService.Interfaces
{
    public interface IWordCalculatorService
    {
        int CalculateWordSum(string word);
    }
}
