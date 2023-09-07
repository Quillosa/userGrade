using System.Collections;

namespace userGrade
{
    public partial class Form1 : Form
    {
        
        name pangalan = new name();
        prelim preli = new prelim();
        midterm midter = new midterm();
        prefinal prefi = new prefinal();
        final fina = new final();
        compute comp = new compute();
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            pangalan.setname(textBox1.Text);
            preli.setpre(Convert.ToInt32(textBox2.Text));
            midter.setmid(Convert.ToInt32(textBox3.Text));
            prefi.setpref(Convert.ToInt32(textBox4.Text));
            fina.setfin(Convert.ToInt32(textBox5.Text));

           

            MessageBox.Show("your information is saved! ");
            
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string searchName = textBox6.Text;

             int index = pangalan.getindex(searchName);

            

                double prelimGrade = preli.getpre(index);
                double midtermGrade = midter.getmid(index);
                double prefinalGrade = prefi.getpref(index);
                double finalGrade = fina.getfin(index);


               

                
                textBox8.Text = prelimGrade.ToString();
                textBox9.Text = midtermGrade.ToString();
                textBox10.Text = prefinalGrade.ToString();
                textBox11.Text = finalGrade.ToString();
                comp.setadd(prelimGrade,midtermGrade, prefinalGrade, finalGrade);
                textBox12.Text = comp.getadd().ToString();

            

        }
    }
}