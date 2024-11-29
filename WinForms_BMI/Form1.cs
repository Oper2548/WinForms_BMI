using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace WinForms_BMI
{
    public partial class Height : Form
    {
        public Height()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        //ปุ่มคำนวณ bmi
        //รับค่าจาก textbox
        {
            //****2****
            //  double height = 0;
            //  if (double.TryParse(txtHeight.Text,out height) == false)
            //  {
            //      MessageBox.Show("กรอกข้อมูลไม่ถูกนะ","นั้น!");
            //      return; //ถ้าใน if เป็นจริง จบ
            //  }
            //  double weight = 0;
            //  if (double.TryParse(txtHeight.Text, out weight) == false)
            //  {
            //      MessageBox.Show("กรอกข้อมูลไม่ถูกนะ", "นั้น!");
            //      return; //ถ้าใน if เป็นจริง จบ
            //  }
            //****2****
            double height = 0;
            double weight = 0;
            if (CheckDoble(txtWeight, txtHeight)) //เรียกใช้ method แบบคืนค่าเป็น true/false
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1  double height = Convert.ToDouble(txtHeight.Text);
            //1  double weight = Convert.ToDouble(txtWeight.Text);


            //คำนวณ bmi
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);  //เรียกใช้method BMI

            //แปลผล นำค่า bmi มาเทียบกับค่ามาตฐาน
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm() //คำสั่งเครียหน้าจอ **เอาไว้ใช้ที่อื่นได้**
        {
            txtAge.TextAlign = HorizontalAlignment.Right; //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtWeight.Text = "0";
            txtHeight.Text = "0";
            txtName.Focus();
        }

        private void InputDataValid(TextBox name, TextBox age, TextBox height, TextBox weight)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkBlue;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkBlue;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private void Height_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ได้เวลาลดน้ำหนัก", "ยีนดีตอนรับ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge, txtHeight, txtWeight);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge, txtHeight, txtWeight);
        }

        private double BMI(double h, double w) //คำนวณ bmi ส่งค่ามา 2 ค่าคือร้ำหนักและส่วนสูง
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;

            //return w / Math.Pow(h / 100, 2);//แบบสั้น
        }
        private bool CheckDoble(TextBox txtW, TextBox txtH) //ตรวจสอบข้อมูลว่าเป็น Double
        {
            double x = 0;
            double h = 0;
            if ((double.TryParse(txtW.Text, out x) == false || (double.TryParse(txtW.Text, out h) == false)))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกนะ", "นั้น!");
                return false;
            }
            return true;
        }
    }
}