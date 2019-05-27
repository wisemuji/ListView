using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName, strAge, strWork; // 나이, 이름, 직업 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void LvView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvView.SelectedItems[0];
            MessageBox.Show("이름 : " + lvi.SubItems[0].Text +
                "\n나이 : " + lvi.SubItems[1].Text +
                "\n직업 : " + lvi.SubItems[2].Text,
                "알림",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.strName = this.txtName.Text;
                this.strAge = this.txtAge.Text;
                this.strWork = this.txtWork.Text;
                ListViewItem lvi =          //리스트뷰에 들어갈 항목 생성
                    new ListViewItem(
                        new string[] { strName, strAge, strWork }
                    );
                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
                this.txtName.Focus();
            }

        }

        private bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 입력해주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 입력해주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWork.Focus();
                return false;
            }

            return true;
        }
    }
}
