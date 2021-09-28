using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cheque Cheque = new Cheque();

            //asiganr valores a las propiedades 
            //atraves de los metodos de propiedad 
            Cheque.setChekid(1);
            Cheque.SetBankid("Agricola");
            Cheque.setUsurioId("Alexis Manuel Calix");
            Cheque.SetMoneyId("2,000");
            Cheque.SetFirmId("A..M..");

            //mostrar los datos del cheque

           /* MessageBox.Show(
                "\nID: " + Cheque.getCheckid() + 
                "\nBanco: " + Cheque.GetBankid()+ 
                "\nUsuario: " +  Cheque.GetUsurio()+
                "\nDinero: " + Cheque.GetMoneyId ()+ 
                "\nfirma: " + Cheque.GetFirmId ()

                );**/


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //utilizando constructor vacio
            Cheque Cheque = new Cheque();

            Cheque.setChekid(Convert.ToInt32(txtid.Text));
            Cheque.SetBankid(txtbanco.Text);
            Cheque.setUsurioId(txtusuario.Text);
            Cheque.SetMoneyId(txtdinero.Text);
            Cheque.SetFirmId(txtfirma.Text);
            

            //utilizando el constructor que inicializa las propiedades
            Cheque Cheque1 = new Cheque(Convert.ToInt32 (txtid.Text ), 
                txtbanco.Text, txtusuario .Text , txtdinero .Text , txtfirma .Text  );

            //agregar los datos a LisBox

            lstcheckinfo.Items.Add("Mediante constructor vacio:" +Cheque.GetHashCode());
            lstcheckinfo.Items.Add("mediante constructor  incializando las  propiedades: " + Cheque1.GetHashCode());

        }
    }  
}
