namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 1 �al��t�");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�");
        }
    }
}
//thread -> boru olarak d���n... bir i�lem bitecek sonra di�er i�lem ba�layacak .. form ve consol uygulamalar�nda single thread vard�r
//multi thred -> birden fazla boru var... birden fazla thread vars�r. thread pool
//asenkron programlamada iki i�lemi benzer zamanlarda ortak kullan�labilir