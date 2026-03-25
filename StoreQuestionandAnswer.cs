using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_POE
{
    internal class StoreQuestionandAnswer
    {
            public string Question { get; set; }
            public string Answer { get; set; }

            public StoreQuestionandAnswer(string q, string a)
            {
                Question = q;
                Answer = a;
            }
    }
}
