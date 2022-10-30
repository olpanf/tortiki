using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class Cake
    {
        public int cost;
        public string form;
        public string size;
        public string taste;
        public string quantity;
        public string glaze;
        public string decor;
        public Cake(int ParamCost, string ParamForm, string ParamSize, string ParamTaste, string ParamQuantity, string ParamGlaze, string ParamDecor)
        {
            cost = ParamCost;
            form = ParamForm;
            size = ParamSize;
            taste = ParamTaste;
            quantity = ParamQuantity;
            glaze = ParamGlaze;
            decor = ParamDecor;
        }
    }
}
