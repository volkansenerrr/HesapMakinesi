using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HesapMakinesi
{
    public partial class frm_HesapMakinesi : Form
    {
        public frm_HesapMakinesi() // Form başlatıldığında çalışan Constructor Metot
        {
            InitializeComponent(); // Formun Bileşenlerini başlatan metot
        }

        private void frm_HesapMakinesi_Load(object sender, EventArgs e) // Form yüklendiğinde çalışacak olay metodu.
        {
            tb_Sonuc.SelectionStart = 0; // TextBox'taki imleci en başa ayarladım imleci kaldırmak için

            // Form içindeki tüm kontrolleri döngü ile kontrol eder.
            foreach (Control control in this.Controls) // Form içindeki kontrolleri tek tek dolaş 
            {
                if (control is Button) // Eğer kontrol bir buton türünde ise
                {
                    Button btn = (Button)control; // Kontrolü buton türüne dönüştür buton değişkenine ata

                    btn.FlatStyle = FlatStyle.Flat; // Buton düz bir görünüm alsın (kenarlık, gölge vb. olmadan).

                    btn.FlatAppearance.BorderSize = 0; // Butonun kenarlık kalınlığını 0 yapar. 
                }
            }

        }

        // İmleci gizlemek için kullanılan olay metodu.
        private void ImlecGizle(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Form üzerindeki aktif kontrolü kaldırır, böylece TextBox üzerindeki odaklanma sona erer.
        }

        // Rakam butonlarına tıklandığında çalışacak olay metodu.
        private void RakamOlay(object sender, EventArgs e)
        {
            if (tb_Sonuc.Text == "0") // Eğer TextBox'taki mevcut metin "0" ise, TextBox'ı temizler.
            {
                tb_Sonuc.Clear(); // TextBox'ı temizler.
            }
            Button btn = (Button)sender; // Tıklanan butonu "sender(olay tetikleyicisi)" nesnesinden alır ve "btn" değişkenine atar.

            tb_Sonuc.Text += btn.Text; // Tıklanan butonun üzerindeki metni (rakam) TextBox'a ekler.
        }

        private void OperatorOlay(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }
    }
}
        