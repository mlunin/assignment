using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Game
    {
        static void Main(string[] args)
        {
            List<ConcoleField> Fields = new List<ConcoleField>();
            InputReader curIn = new InputReader();
            OutputWriter CurOut = new OutputWriter();
            ConsoleInputValidator inputChecker = new ConsoleInputValidator();
            string text;

            do
            {
                IMinesMap curMap = new MinesMap();
                curIn.Set(inputChecker, ref curMap); 
                curIn.ReadInput();
                if (curIn.LastStatus == 1)
                {
                    ConcoleField MyField = new ConcoleField(curMap);
                    Fields.Add(MyField);
                }
                else
                    break;
            }
            while (true);

            for (int i = 0; i < Fields.Count; i++)
            {
                CurOut.Set(Fields[i].FieldMap);
                Console.WriteLine();
                text = "Field #" + (i + 1).ToString() + ":";
                Console.WriteLine(text);
                CurOut.WriteOutput();
            }
            Console.ReadKey();
        }
    }
}
