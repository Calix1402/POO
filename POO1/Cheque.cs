using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO1
{
    class Cheque
    {
        //Defenir los miembros de las clases 
        //Metodos y Prpiedades 

        //Metodos

        public int  _check;        //cheque 
        public string _Bank;       //Banco
        public string _Usuario;    //Nombre del usuario
        public string  _Money;     //Cantidad de $
        public string  _Firm;      //Firma 

        //propiedades
        // Get---permite obtener el codigo del cheque 
        // Set--Asigna el coidgo del cheque

        private string Form1 { get; set; }
        private string publisheYear { get; set; }
       
        //metodo constructor

        public Cheque()
        { }

        //soporte de sobre carga de constructor 
        public Cheque(int cheque, string banco, string usuario, string Dinero, string Firma)
        {
            _check = cheque;
            _Bank = banco;
            _Usuario = usuario;
            _Money = Dinero;
            _Firm = Firma;
        }
        

        public  int getCheckid()
        {
            return _check;
        }

        

        // set-- permite asignar el codigo al cheque 
        public void setChekid(int Checkid)
        {
            _check = Checkid;
        }

        public  string GetBankid()
        {
            return _Bank;
        }

        public void SetBankid(string BankId)
        {
            _Bank = BankId;
        }

       public string    GetMoneyId()
        {
            return _Money;
        }

        public void  SetMoneyId (string  Dinero)
        {
            _Money = Dinero; 
        }

        public string GetUsurio()
        {
            return _Usuario;
        }

        public void   setUsurioId (string UsuarioId)
        {
            _Usuario = UsuarioId;
        }

        public  string GetFirmId()
        {
            return _Firm ;
        }

        public void SetFirmId(string FirmId)
        {
           _Firm  = FirmId;
        }

            //metodo para mostrar la informacion del libro
              public string CheckidInfo()
              {
                 return " id: " + _check + "Banco: " + _Bank + " Usuario: " + _Usuario + 
                     " Dinero: " + _Money +  "firma: " + _Firm;
              }

      




    }
}



    


