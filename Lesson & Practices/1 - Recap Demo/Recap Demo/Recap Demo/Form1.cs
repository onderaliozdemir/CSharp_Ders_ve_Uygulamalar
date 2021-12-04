using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama Açıldığında 8*8 lik dama tahtası yapmak. Toolbox dan 64 tane button eklemek yerine Button zaten bir class dır. Class ile  kullanacağız.

            #region 1 - En Basit Kullanım
            /*
            Button button = new Button(); // Button nesnesi oluşturduk.
            button.Height = 50; // button nesnesinin property si.
            button.Width = 50; // button nesnesinin property si.
            button.Text = "My Button."; // button nesnesinin property si.
            this.Controls.Add(button);
            */

            #endregion

            #region 2 - Orta Kullanım

            for (int i = 0; i < 64; i++)
            {
                Button btn = new Button();
                btn.Name = "btn_" + i.ToString(); 
                // vs...
            }

            // yada

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn_" + i.ToString() + "_" + j.ToString();
                    // vs..
                }
            }

            #endregion

            #region 3 - Profesyonel Kullanım

            Button[,] buttons = new Button[8,8]; // 8*8 button array'ı olarak tanımladık.
            int top=0; //button konumu için
            int left=0; // soldan uzaklık
            /*
             GetUpperBound : Çok boyutlu dizilerde boyut index'inin alabileceği en yüksek değeri verir.. (Yani 7)
             0 dersek [8,8] ilk 7 e ulaşırız. 1 dersek ikinci 7 e ulaşırız.
            */
            for (int i = 0; i < buttons.GetUpperBound(0); i++) 
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    if ((i+j)%2==0) // Buradaki algoritma nasıl çalışıyor ??
                    {
                        // MOD ALMA (a%b) NEDİR?
                        /*
                         * Bir sayının diğer sayıya bölündüğünde kalan değeridir. Örnek 8/5 = 3 . Mod 3tür.
                         * */
                        // i = 0 && j = 0 ---- > 0+0 % 2 = 0  Black (İlk satırın ilk butonu)
                        // i = 0 && j = 1 -----> 0+1 % 2 = 1  White
                        // i = 0 && j = 2 -----> 0+2 % 2 = 0  Black
                        // ....
                        // ....
                        // İkinci satıra geçtik ..  i = 1 && j=0 -- > 1+0 % 2 = White (İkinci satırın ilk butonu)
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                // ikinci satıra geçtiğim de left sıfır olcak. Artık üst taraftan uzaklık vereceğiz.
                left = 0;
                top += 50;
            }
            #endregion

        }
    }
}
