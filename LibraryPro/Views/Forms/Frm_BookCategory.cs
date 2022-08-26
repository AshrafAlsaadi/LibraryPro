using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryPro.Logic.Presenters;
using Library.Views.Interface;

namespace Library.Views.Forms
{
    public partial class Frm_BookCategory : XtraForm, IbookCategory
    {
        CategoryPresenter catPresenter;

       public int Id { get => Convert.ToInt32(txtId.Text); set => txtId.Text = value.ToString(); }
       public string  CatName { get =>txtName.Text; set => txtName.Text =value.ToString(); }
       

        public Frm_BookCategory()
        {
            InitializeComponent();
            catPresenter = new CategoryPresenter(this);
        }

        private void Frm_BookCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bool check= catPresenter.CatInsert();
            if(check)
            {
                MessageBox.Show("تم الاضافة");
            }
            else
            {
                MessageBox.Show("حاول مرة اخرى");
            }
        }
    }
}