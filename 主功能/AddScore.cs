using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualBasic;
using System.Windows.Forms;
using SystemTool.数据类;
using SystemTool.工具类;
using Microsoft.VisualBasic;

namespace Education_System.主功能
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetScoreData("SELECT Student.Sno, Sname, sc.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade IS NULL; ");
            }
            db.DBclose();//关闭数据库连接
            dataGridView1.Rows.Clear(); //初始化dataGridView

            for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGirdCourse中
            {
                int index = this.dataGridView1.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.dataGridView1.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                this.dataGridView1.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                this.dataGridView1.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                this.dataGridView1.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                this.dataGridView1.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];
                //this.dataGridView1.Rows[index].Cells[5].Value = ScoreInfo.name[i];
            }
            //控制显示用户信息数据的dataGridView出现的位置
            dataGridView1.Height = 219;
            dataGridView1.Width = 930;
            dataGridView1.Visible = true;//显示数据集
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string[] Sno = new string[dataGridView1.Rows.Count];
            string[] Cno = new string[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    Sno[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Cno[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
            String snum = null;
            String cnum = null;
            for (int j = 0; j < Sno.Count(); j++)
            {
                snum = snum + Sno[j];
                cnum = cnum + Cno[j];
            }
            if (snum == null)
            {
                MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
                string grade = Interaction.InputBox("请输入成绩！", "录入成绩", "", 500, 300);
                id = grade.ToString().Equals("") ? 0 : Convert.ToInt32(grade.ToString());
                if (id != 0)
                {
                    string stri = "update sc set Grade = " + grade + " where Sno = " + snum + " and Cno = " + cnum;
                    DBlink db = new DBlink();   //创建数据库连接对象
                    db.DBconn();//连接数据库
                    if (db.UpdataDeletAdd(stri))
                    {
                        DialogResult dr = MessageBox.Show("成绩录入成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("成绩录入失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            AddScore_Load(null, null);
        }
    }
}
