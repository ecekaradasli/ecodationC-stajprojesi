using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void burc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (burc.Text == "Koç")
            {
                comment.Text = "12 burcun ilki olan Koç burcu Zodyak’ın başında yer alır. \nGüneş, her bahar bu burcu 20 Mart-19 Nisan tarihleri arasında \nziyaret eder. Yıldız haritanızda Koç burcu gezegen yerleşimine sahip \nolmasanız da pek çok gezegen yıl boyunca Koç burcundan geçerek onun \nyakıcı enerjisini harekete geçirdiği için bu burcun enerjisini anlamak önemlidir.";

                image.Image = burcresim.Images["koc.png"];
            }
            else if (burc.Text == "Boğa")
            {
                comment.Text = "Zodyak’ın 12 burcundan ikinci olan Boğa burcunun döngüsü her yılın \n20 Nisan – 20 Mayıs tarihleri arasında başlar. \nYıldız haritanızda Boğa burcu gezegen yerleşimine sahip olsanız da olmasanız \nda yıl boyunca çeşitli gezegenler Boğa burcunu ziyaret ederek bu burcun \ntoprak enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["boga.png"];
            }
            else if (burc.Text == "İkizler")
            {
                comment.Text = "Zodyak’ın 12 burcunun üçüncüsü olan İkizler burcunun döngüsü \nilkbaharın sonlarında başlar, 21 Mayıs – 20 Haziran tarihleri \narasına denk gelir. Yıldız haritanızda İkizler burcu gezegen yerleşimine \nsahip olmasanız da pek çok gezegen yıl boyunca İkizler burcunun rüzgarlı \nenerjisini harekete geçirerek bu burçtan geçtiği için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["ikizler.png"];
            }
            else if (burc.Text == "Yengeç")
            {
                comment.Text = "Zodyak’ın 12 burcundan dördüncü burç olan Yengeç burcunun döngüsü her yılın \n21 Haziran – 22 Temmuz tarihleri arasında başlar. \nYıldız haritanızda Yengeç burcu gezegen yerleşimine sahip olmasanız da\n yıl boyunca çeşitli gezegenler Yengeç burcunu ziyaret ederek bu burcun \nsu enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["yengec.png"];
            }
            else if (burc.Text == "Aslan")
            {
                comment.Text = "Zodyak’ın 12 burcundan beşinci burç olan Aslan burcunun döngüsü her yılın \n23 Temmuz – 22 Ağustos tarihleri arasında gerçekleşir. \nYıldız haritanızda Aslan burcu gezegen yerleşimine sahip olmasanız da \nyıl boyunca çeşitli gezegenler Aslan burcunu ziyaret ederek \nateş enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["aslan.png"];
            }
            else if (burc.Text == "Başak")
            {
                comment.Text = "Zodyak’ın 12 burcundan altıncısı olan Başak burcunun döngüsü her yılın \n23 Ağustos – 22 Eylül tarihleri arasında gerçekleşir. \nYıldız haritanızda Başak burcu gezegen yerleşimine sahip olmasanız da yıl\n boyunca çeşitli gezegenler Başak burcunu ziyaret ederek bu burcun \ntoprak enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["basak.png"];
            }
            else if (burc.Text == "Terazi")
            {
                comment.Text = "Zodyak’ın 12 burcundan yedincisi olan terazi burcunun döngüsü her yılın \n23 Eylül – 22 Ekim tarihleri arasında gerçekleşir. \nYıldız haritanızda Terazi burcu gezegen yerleşimine sahip olmasanız da yıl\n boyunca çeşitli gezegenler Terazi burcunu ziyaret ederek bu burcun \nhava enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["terazi.png"];
            }
            else if (burc.Text == "Akrep")
            {
                comment.Text = "Zodyak’ın 12 burcundan sekizincisi olan Akrep burcunun döngüsü her yılın \n24 ekim – 23 kasım tarihleri arasında gerçekleşir. \nYıldız haritanızda Akrep burcu gezegen yerleşimine sahip olmasanız da yıl \nboyunca çeşitli gezegenler Akrep burcunu ziyaret ederek bu burcun \nsu enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["akrep.png"];
            }
            else if (burc.Text == "Yay")
            {
                comment.Text = "Zodyak’ın 12 burcundan dokuzuncusu olan Yay burcunun döngüsü her yılın \n22 Kasım – 21 Aralık tarihleri arasında gerçekleşir. \nYıldız haritanızda Yay burcu gezegen yerleşimine sahip olmasanız da yıl \nboyunca çeşitli gezegenler Yay burcunu ziyaret ederek bu burcun \nateş enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["yay.png"];
            }
            else if (burc.Text == "Oğlak")
            {
                comment.Text = "Zodyak’ın 12 burcundan onuncusu olan Oğlak burcunun döngüsü her yılın \n22 Aralık – 19 Ocak tarihleri arasında gerçekleşir. \nYıldız haritanızda Oğlak burcu gezegen yerleşimine sahip olmasanız da yıl \nboyunca çeşitli gezegenler Oğlak burcunu ziyaret ederek bu burcun \ntoprak enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["oglak.png"];
            }
            else if (burc.Text == "Kova")
            {
                comment.Text = "Zodyak’ın 12 burcundan on birincisi olan Kova burcunun döngüsü her yılın \n21 Ocak – 18 Şubat tarihleri arasında gerçekleşir. \nYıldız haritanızda Kova burcu gezegen yerleşimine sahip olmasanız da yıl \nboyunca çeşitli gezegenler Kova burcunu ziyaret ederek bu burcun \nhava enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["kova.png"];
            }
            else if (burc.Text == "Balık")
            {
                comment.Text = "Balık Zodyak’ın 12 burcundan on ikincisi olan Balık burcunun döngüsü her yılın \n19 Şubat – 20 Mart tarihleri arasında gerçekleşir. \nYıldız haritanızda Balık burcu gezegen yerleşimine sahip olmasanız da \nyıl boyunca çeşitli gezegenler Balık burcunu ziyaret ederek bu burcun \nsu enerjisini uyandırdığı için bu enerjiyi anlamak önemlidir.";

                image.Image = burcresim.Images["balik.png"];
            }
        }

        private void comment_Click(object sender, EventArgs e)
        {

        }
    }
}
