using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Aula_FuncaMultiRetorno
{
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        /// <summary>
        /// Atualiza dg dos valores  meses ja calculados
        /// </summary>
        private void AtualizaDG()
        {
            List<string[]> list = DBFunction.GenericSelectAll("Historico");
            dgHistorico.Rows.Clear();

            foreach (var item in list)
            {
                dgHistorico.Rows.Add(item);
            }

            for (int i = 0; i < dgHistorico.Rows.Count; i++)
            {
                if (Convert.ToDouble(dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Value.ToString())<0)
                {
                    dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

            double valorLiquido = 0, novoSaldo = 0, despesas = 0 , ganhos = 0;
            bool lucrou = false  ;

            
            
            double valor = Convert.ToDouble(dgHistorico.Rows[dgHistorico.Rows.Count-1].Cells[1].Value);
            despesas = Convert.ToDouble(txtDespesa.Text);
            ganhos = Convert.ToDouble(txtGanho.Text);

            CalculaMes(valor, despesas, ganhos, out valorLiquido, out novoSaldo, out lucrou);

            string insert = $"insert into dbo.Historico(ValorEmCaixa, DespesasDoMes, GanhosDoMes, ValorLiquido, SeLucrou) values ({novoSaldo.ToString(CultureInfo.InvariantCulture)},{despesas.ToString(CultureInfo.InvariantCulture)},{ganhos.ToString(CultureInfo.InvariantCulture)},{valorLiquido.ToString(CultureInfo.InvariantCulture)},{Convert.ToInt32(lucrou)})";

            DBFunction.GenericExecute(insert);
            AtualizaDG();
        }
        
        private void CalculaMes(double saldoAtual, double despesas, double ganhos, out double valorLiquido, out  double novoSaldo, out bool deuLucro)
        {
            valorLiquido = ganhos - despesas;
            novoSaldo = saldoAtual + valorLiquido;
            if (valorLiquido > 0 )
            {
                deuLucro = true;

            }
            else
            {
                deuLucro = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            string delete = "Delete from dbo.Historico where idHistorico > 1";
            DBFunction.GenericExecute(delete);
            AtualizaDG();
        }
    }
}
