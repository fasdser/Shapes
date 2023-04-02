using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Board
    {
        private Shape[] parts = new Shape[4];

        public Board()
        {
        }

        public Shape[] GetParts()
        {
            return parts;
        }

        public void AddShape(Shape shape, int part)
        { // добавит фигуру в указанную часть от 1 до 4
            if (part > 0 && part < 5)
            {
                if (parts[part - 1] == null)
                {
                    parts[part - 1] = shape;                   
                }            
            }         
        }

        public void AddShape(Shape shape)
        { // добавит фигуру на любое свободное место (при наличии)
            bool add = false;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == null)
                {
                    parts[i] = shape;
                    add = true;                   
                    break;
                }
            }            
        }

        public void DelShape(int part)
        { // удалит фигуру из указанной части от 1 до 4
            if (part > 0 && part < 5)
            {
                if (parts[part - 1] != null)
                {
                    parts[part - 1] = null;              
                }              
            }       
        }

        public void Info()
        {
            double p = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] != null)
                {
                    p += parts[i].GetArea();                    
                }              
            }         
        }
    }
}
