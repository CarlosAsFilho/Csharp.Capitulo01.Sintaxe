using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comentário 
           /* int x = 43;
            string nome = "Vitor";
            char letra = 'a';
            bool aprovado = true;
            aprovado = false;

            DateTime datanascimento = new DateTime(200,02,25);*/
            var a = 2;
            var b = 6;
            var c = 7;
            var d = 8;

            //object meuobjeto = 34;
            //meuobjeto = "vitor";
            //meuobjeto = false;

            //var valor = 5.6m;
            //var bimestre1 = 5.9m;
            //int numero = 11, outronumero = 12, essenumero = 13;
            
            resultadoListBox.Items.Add("a= "+a);
            resultadoListBox.Items.Add(string.Concat("b=",b));
            //resultadoListBox.Items.Add(string.Format("c ={0}-d ={1}",c,d));
            resultadoListBox.Items.Add(string.Format("c ={0}", c));
            resultadoListBox.Items.Add($"d ={d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"a / d = {a / d}");
            resultadoListBox.Items.Add($"a % b = {a % b}");


        }

    

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x =" + x);
            //x = x - 3;
            x -= 3;
            resultadoListBox.Items.Add("x = " + x);
        }
    }
}
