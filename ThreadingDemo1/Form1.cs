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
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}
//thread -> boru olarak düþün... bir iþlem bitecek sonra diðer iþlem baþlayacak .. form ve consol uygulamalarýnda single thread vardýr
//multi thred -> birden fazla boru var... birden fazla thread varsýr. thread pool
//asenkron programlamada iki iþlemi benzer zamanlarda ortak kullanýlabilir