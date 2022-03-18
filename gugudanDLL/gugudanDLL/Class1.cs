using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace gugudanDLL
{
    public class GugudanClass
    {
        ArrayList al = new ArrayList();
        string result;

        public ArrayList Print()
        {
            for(int i=2; i<=9; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    result = i + "*" + j + "=" + i * j;
                    al.Add(result);
                }
            }
            return al;
        }

        public ArrayList Print2(int num1,int num2)
        {
            for(int i=num1; i<=num2; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    result = i + "*" + j + "=" + i * j;
                    al.Add(result);
                }
            }
            return al;
        }
    }
}
