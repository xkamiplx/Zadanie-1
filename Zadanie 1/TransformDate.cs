using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TransformDate{
    private const char
        Space = ' ',
        Connector = '-';
    public static string nameUP(string fraza){
        string[] breakMain = fraza.Trim().Split(Space);
        for (int ig = 0; ig < breakMain.Length; ig++)
        {
            string[] breakSecondary = breakMain[ig].Split(Connector);
            for (int ip = 0; ip < breakSecondary.Length; ip++)
                breakSecondary[ip] = nameFirstLetterUP(
                    breakSecondary[ip]
                    );
            breakMain[ig] = string.Join(Connector, breakSecondary);
        }
        return string.Join(Space, breakMain);
    }

    public static string nameFirstLetterUP(string word){
        word = word.Trim();
        if (word == "")
            return "";
        else
        {
            string
                first = word.Substring(0, 1).ToUpper(),
                rest = word.Substring(1).ToLower()
                ;
            return first + rest;
        }
    }
}

