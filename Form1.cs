using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabela_de_busca
{
    public partial class Form1 : Form
    {
        public List <Dados> dados { get; set;  }

        public Form1()
        {
            InitializeComponent();
            dados = new List<Dados>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados.Add(new Dados { Nome = textNome.Text });
            GridNome.DataSource = null;
            GridNome.DataSource = dados;
            textNome.Text = "";


           
      

        }

        public class Dados
        {
            public string Nome { get; set; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
