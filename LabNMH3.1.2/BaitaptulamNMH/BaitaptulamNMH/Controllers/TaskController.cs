using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNamespace.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult PrimeNumbers()
        {
            List<int> primeNumbers = new List<int>();

            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }

            return View(primeNumbers);
        }

        public ActionResult Factorials()
        {
            Dictionary<int, long> factorials = new Dictionary<int, long>();

            for (int i = 1; i <= 10; i++)
            {
                long factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                factorials.Add(i, factorial);
            }

            return View(factorials);
        }

        public ActionResult MultiplicationTable()
        {
            return View();
        }
    }
}