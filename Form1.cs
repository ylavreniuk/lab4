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
using Lab3;

namespace Lab04
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCamera.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Contry";
            column.Name = "Страна виробництва";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SceenDiagonal";
            column.Name = "Діагональ екрану";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MatrixSize";
            column.Name = "Розмір матриці";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfProduction";
            column.Name = "Рік виробництва";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Вага";
            gvCamera.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "LensInterchangeable";
            column.Name = "Має об'єктив";
            gvCamera.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            gvCamera.Columns.Add(column);

            bindSrcCamera.Add(new Camera("Nikon", "D3500", "Japan", 3, 24, 2019, 365, true, 20000));
            EventArgs eventArgs = new EventArgs(); OnResize(eventArgs);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();

            fCamera fbc = new fCamera(camera);
            if (fbc.ShowDialog() == DialogResult.OK)
            {
                bindSrcCamera.Add(camera);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Camera camera = (Camera)bindSrcCamera.List[bindSrcCamera.Position];

            fCamera fbc = new fCamera(camera);
            if (fbc.ShowDialog() == DialogResult.OK)
            {
                bindSrcCamera.List[bindSrcCamera.Position] = camera;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            { bindSrcCamera.RemoveCurrent(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                bindSrcCamera.List.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
