using System;
using System.Collections.Generic;
using System.Text;

namespace PGJP
{
    class PGJP
    {
        static string ParashtesaPerbashketHelper(string stringu1, string stringu2)
        {
            string result = "";

            int n1 = stringu1.Length,
                n2 = stringu2.Length;

            for (int i = 0, j = 0; i <= n1 - 1 && j <= n2 - 1; i++, j++)
            {
                if (stringu1[i] != stringu2[j])
                    break;

                result += stringu1[i];
            }

            return (result);
        }

        public static string parashtesaPerbashket(string[] stringArray, int l, int r)
        {
            if (l == r)
                return (stringArray[l]);

            if (r > l)
            {
                int mid = (l + r) / 2;

                string stringu1 = parashtesaPerbashket(stringArray, l, mid);
                string stringu2 = parashtesaPerbashket(stringArray, mid + 1, r);

                return (ParashtesaPerbashketHelper(stringu1, stringu2));
            }

            return null;
        }
    }
}
