namespace SayiOkuyucuFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (txtSayi.Text.Length >= 4)
                e.Handled = true;
        }

        private void txtSayi_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSayi.Text.Length != 0)
                SayiyiMetneCevir();
            else if (txtSayi.Text.Length == 0)
            {
                txtSayi.Text = "0";
                SayiyiMetneCevir();
            }
        }
        private void SayiyiMetneCevir()
        {
            string[] birler = { "", "Bir", "�ki", "��", "D�rt", "Be�", "Alt�", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "K�rk", "Elli", "Altm��", "Yetmi�", "Seksen", "Doksan" };
            string[] yuzler = { "", "Y�z", "�kiY�z", "��Y�z", "D�rtY�z", "Be�Y�z", "Alt�Y�z", "YediY�z", "SekizY�z", "DokuzY�z" };
            string[] binler = { "", "Bin", "�kiBin", "��Bin", "D�rtBin", "Be�Bin", "Alt�Bin", "YediBin", "SekizBin", "DokuzBin" };
            string[] milyonlar = { "", "BirMilyon", "�kiMilyon", "��Milyon", "D�rtMilyon", "Be�Milyon", "Alt�Milyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
            int girilenSayi = int.Parse(txtSayi.Text);

            if (girilenSayi == 0)
            {
                lblEkran.Text = "S�f�r";
                return;
            }

            int basamak1 = girilenSayi % 10;
            int basamak10 = girilenSayi / 10 % 10;
            int basamak100 = girilenSayi / 100 % 10;
            int basamak1000 = girilenSayi / 1000 % 10;
            int basamak10000 = girilenSayi / 10000 % 10;
            int basamak100000 = girilenSayi / 100000 % 10;
            int basamak1000000 = girilenSayi / 1000000 % 10;
            string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";
            lblEkran.Text = okunus;
        }
    }
}