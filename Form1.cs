using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Generator_CSTEST
{
    public partial class Form1 : Form
    {
        Random RNG = new Random(new DateTime().Millisecond);
        List<char> lower = new List<char>{
            'a','b','c','d','e','f','g','h','i',
            'j','k','l','m','n','o','p','q','r',
            's','t','u','v','w','x','y','z' };
        List<char> upper = new List<char> {
            'A','B','C','D','E','F','G','H','I',
            'J','K','L','M','N','O','P','Q','R',
            'S','T','U','V','W','X','Y','Z' };
        List<char> numbr = new List<char> {
            '0','1','2','3','4','5','6','7','8','9'};
        List<char> symb = new List<char>{
            '!','@','#','$','%','^','&','*',
            '(',')','_','=','+'};

        public Form1()
        {
            InitializeComponent();
            
        }


        private void btn_Go_Click(object sender, EventArgs e)
        {
            List<char> c = new List<char> { };
            if (ck_lower.Checked)
            {
                c.AddRange(lower);
            }

            if (ck_upper.Checked)
            {
                c.AddRange(upper);
            }

            if (ck_symbols.Checked)
            {
                c.AddRange(symb);
            }

            if (ck_numbers.Checked)
            {
                c.AddRange(numbr);
            }

            int stringLen = Decimal.ToInt32(spinner_Length.Value);
            int arrayLen = c.Count-1;
            String output = "";
            if (c.Count <= 0)
            {
                txt_Output.Text = "Check at least one box";
            }
            else
            {
                for (int i = 0; i < stringLen; i++)
                {
                    int a = RNG.Next(0, arrayLen);
                    output = output + c[a];
                }
                txt_Output.Text = output;
            }

           
        }
    }
}
