using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarfSayiyaCevirme
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      char[] harfler = new char[] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
      int metinBoyut = txtMetin.Text.Length;
      int toplam = 0;
      string metin = txtMetin.Text;
      // MessageBox.Show(metin[0].ToString());
      for (int i = 0; i < metinBoyut; i++)
      {
        for (int j = 0; j < harfler.Length; j++)
        {
          if (metin[i] == harfler[j])
            toplam += j + 1;
        }
      }
      if (toplam <= 0)
        lblSonuc.Text = "Dizide yok";
      else
      lblSonuc.Text = toplam.ToString();

    }
    
    //if(toplam>=0)
    //        MessageBox.Show(toplam.ToString());
  }

}   
     
  

