using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Libreria
{
    public class Utilidades
    {
        public static void LimpiarForm(System.Windows.Forms.Control C)
        {
            foreach (System.Windows.Forms.Control c in C.Controls )
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    LimpiarForm(c);
                }
            }
        }
    }
}
