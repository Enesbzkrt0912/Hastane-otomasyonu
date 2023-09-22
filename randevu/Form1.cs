using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace randevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string bcum = "provider=microsoft.jet.oledb.4.0;data source=hastane.mdb";// bağlanrı 

        void listboxa_bagla(ListBox lb,string sql)
        {
            OleDbDataAdapter a = new OleDbDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            lb.DataSource = t;
            lb.ValueMember = t.Columns[0].ColumnName;
            lb.DisplayMember = t.Columns[1].ColumnName;      
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from poller order by pol asc";// poller tablosundaki verileri lb yazar 
            listboxa_bagla(lbPol, sql);

            randevu_listele();
        }

        private void lbPol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //seçilen polno hafızaya alınıyor
                string polno = lbPol.SelectedValue.ToString();
                string sql = "select * from doktorlar where polno=" + polno;
                listboxa_bagla(lbDoktor, sql);

            }
            catch
            {
                return; //Bir hata olursa olaydan çık
            }
        }

        void musait_saatleri_getir()
        {
            string doktorno, tarih, sql;
            //ekrandan alınan değerler hafızaya alınıyor
            doktorno = lbDoktor.SelectedValue.ToString();
            tarih = dtTarih.Value.ToShortDateString();

            sql = "select * from saatler where saatno not in (" +
                  "select saatno from randevular where doktorno=" +
                  doktorno + " and tarih='" + tarih + "')";

            listboxa_bagla(lbSaat, sql);
        }
        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            musait_saatleri_getir();
        }


        void randevu_listele()
        {
            string sql;

            sql = "select r.tcno,r.hasta,p.pol,d.doktor,r.tarih,s.saat " +
                  "from randevular r,poller p,doktorlar d,saatler s " +
                  "where r.doktorno=d.doktorno and r.saatno=s.saatno " +
                  "and d.polno=p.polno order by randno desc";

            OleDbDataAdapter a = new OleDbDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            dgRandevular.DataSource = t;
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            string sql, doktorno, tarih, saatno, tcno, hasta;
            doktorno = lbDoktor.SelectedValue.ToString();
            tarih = dtTarih.Value.ToShortDateString();
            saatno = lbSaat.SelectedValue.ToString();
            tcno = tbTc.Text;
            hasta = tbHasta.Text;

            sql = "insert into randevular (tcno,hasta,doktorno,tarih,saatno) " +
                  "values ('" + tcno + "','" + hasta + "'," + doktorno + ",'" +
                  tarih + "'," + saatno + ")";

            OleDbConnection b = new OleDbConnection(bcum);
            OleDbCommand k = new OleDbCommand(sql, b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Randevu Alınmıştır.. Geçmiş Olsun..");
            b.Close();
            musait_saatleri_getir();
            randevu_listele();

        }

        private void lbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgRandevular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
