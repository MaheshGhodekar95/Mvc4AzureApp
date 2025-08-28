using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4AzureApp.Services
{

    public interface ICalculatorService
    {
        int Add(int a, int b);
    }
    public class CalculatorService : ICalculatorService
    {

        

        
            public int Add(int a, int b)
            {
                return a + b;
            }
        
    }
}