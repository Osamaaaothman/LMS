using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public interface IFineCalculator
    {
        double CalculateFine(int daysLate);
    }
}
