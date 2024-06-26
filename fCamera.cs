using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace Lab3
{

    public partial class fCamera : Form
    {
        
        public Camera TheCamera;
        public fCamera(Camera t)
        {
            TheCamera = t;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheCamera.Name = tbName.Text.Trim();
            TheCamera.Model = tbModel.Text.Trim();
            TheCamera.Contry = tbContry.Text.Trim();
            TheCamera.SceenDiagonal = int.Parse(tbSceenDiagonal.Text.Trim());
            TheCamera.MatrixSize = int.Parse(tbMatrixSize.Text.Trim());
            TheCamera.YearOfProduction = double.Parse(tbYearOfProduction.Text.Trim());
            TheCamera.Weight = double.Parse(tbWeight.Text.Trim());
            TheCamera.LensInterchangeable = chbLensInterchangeable.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(TheCamera != null)
            {
                tbName.Text = TheCamera.Name;
                tbModel.Text = TheCamera.Model;
                tbContry.Text = TheCamera.Contry;
                tbSceenDiagonal.Text = TheCamera.SceenDiagonal.ToString();
                tbMatrixSize.Text = TheCamera.MatrixSize.ToString();
                tbYearOfProduction.Text = TheCamera.YearOfProduction.ToString();
                tbWeight.Text = TheCamera.Weight.ToString();
                chbLensInterchangeable.Checked = TheCamera.LensInterchangeable;
            }

        }
    }

}
