using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnc_deneme
{
    public partial class cnc_control_screen : Form
    {
        public cnc_control_screen()
        {
            InitializeComponent();
        }

        #region *****VARIABLES*****

        SerialPort seri_port = new SerialPort(); // Seri port nesnesi oluşturuldu.
        string com_port = ""; // Port numarası için değişken atandı.
        int baud_rate; // Baud rate için değer atandı.
        string g_code = ""; // Gcode için değişken atandı.
        int step_size;

        #endregion

        #region *****SERIAL EVENT*****

        private void connect_button_Click(object sender, EventArgs e)
        {
            com_port = "COM" + com_port_number_select.Text; // Port numarası seçilip değişkene aktarıldı.
            baud_rate = Convert.ToInt32(baud_rate_select.Text); // Baud rate belirlenip değişkene aktarıldı.

            try
            {
                seri_port.PortName = com_port; ; // Port numarası nesne değişkenine aktarıldı.
                seri_port.BaudRate = baud_rate; // Baud rate nesne değişkenine aktarıldı.
                seri_port.DataBits = 8; // Seri port haberleşme 8 bit olarak belirlendi.
                seri_port.Parity = Parity.None; // Parity biti eklenmedi.
                seri_port.StopBits = StopBits.One; // 1 stop biti eklendi.
                seri_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); // Seri port dinleme fonksiyonu tanımlandı.
                seri_port.Open(); // Seri port açıldı.
            }
            catch (Exception ex) { }

            if (seri_port.IsOpen) // Seri port açık/kapalı durumuna göre "connect" butonunun texti ve rengi değiştirildi.
            {
                connect_button.Text = "CONNECTED";
                connect_button.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                connect_button.Text = "CONNECT";
                connect_button.ForeColor = System.Drawing.Color.Red;
            }
        }        

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

        } // Seri port dinleme fonksiyonu.

        private void serial_Write() // Seri port yazma fonksiyonu.
        {
            try // Hata yakalayıcı eklendi.
            {
                seri_port.Write(g_code); // g_code değişkeni seri porta yazıldı.
            }
            catch {}
        }

        #endregion

        #region*****CONTROL BUTTON EVENT*****

        private void x_axis_left_Click(object sender, EventArgs e) // Kalem sola manuel hareket fonksiyonu.
        {
            g_code = "X" + step_size_select.Text + "L\n"; // X = X ekseni, L = Left
            serial_Write();
        }

        private void x_axis_right_Click(object sender, EventArgs e) // Kalem sağa manuel hareket fonksiyonu.
        {
            g_code = "X" + step_size_select.Text + "R\n"; // X = X ekseni, R = Right
            serial_Write();
        }

        private void y_axis_rev_Click(object sender, EventArgs e) // Kalem arkaya manuel hareket fonksiyonu.
        {
            g_code = "Y" + step_size_select.Text + "R\n"; // Y = Y ekseni, R = Reverse
            serial_Write();
        }

        private void y_axis_fwd_Click(object sender, EventArgs e) // Kalem öne manuel hareket fonksiyonu.
        {
            g_code = "Y" + step_size_select.Text + "F\n"; // Y = Y ekseni, F = Forward
            serial_Write();
        }        

        private void z_axis_up_Click(object sender, EventArgs e) // Kalem yukarı manuel hareket fonksiyonu.
        {
            g_code = z_axis_max.Text + "ZU\n"; // Z = Z ekseni, U = Up
            serial_Write();
        }

        private void z_axis_down_Click(object sender, EventArgs e) // Kalem aşağı manuel hareket fonksiyonu.
        {
            g_code = z_axis_min.Text + "ZD\n"; // Z = Z ekseni, D = Down
            serial_Write();
        }

        private void reset_button_MouseClick(object sender, MouseEventArgs e) // Koordinat sıfırlama butonu fonksiyonu.
        {
            g_code = "CR\n"; // C = Coordinate, R = Reset
            serial_Write();
        }

        private void setting_save_button_Click(object sender, EventArgs e) // Ayar kayıt butonu fonksiyonu.
        {   // S...S...S...S...S...S
            g_code =  "S" + speed_setting.Value.ToString();
            g_code += "S" + z_axis_min.Text + "S" + z_axis_max.Text;
            g_code += "S" + x_step_mm.Text  + "S" + y_step_mm.Text + "S\n";
            serial_Write();           
        }

        #endregion

        private void z_axis_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void step_size_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_code =   step_size_select.SelectedIndex + "S\n";
            serial_Write();
        }

        private void speed_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g_code = z_axis_min.Text + "ZD\n"; 
            serial_Write();
            bekle(1);
            g_code = "X" + kare_kenar_uzunluk.Text + "R\n"; 
            serial_Write();
            bekle(1);
            g_code = "Y" + kare_kenar_uzunluk.Text + "R\n";
            serial_Write();
            bekle(1);
            g_code = "X" + kare_kenar_uzunluk.Text + "L\n";
            serial_Write();
            bekle(1);
            g_code = "Y" + kare_kenar_uzunluk.Text + "F\n";
            serial_Write();
            bekle(1);
            g_code = z_axis_max.Text + "ZU\n"; 
            serial_Write();

        }
        void bekle(int saniye)
        {
            saniye = ((saniye + Convert.ToInt32(DateTime.Now.Second)) % 60);
            for (; ; )
            {
                if (saniye == DateTime.Now.Second) break;
            }
        }
    }
}
