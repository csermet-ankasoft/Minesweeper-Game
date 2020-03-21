using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_Game
{
    public partial class FormGamePlace : Form
    {
        public FormGamePlace()
        {
            InitializeComponent();
        }

        //CREATED BY CANER SERMET

        //FIRST VARIABLE
        Button[,] buttonArray = new Button[150, 150];
        int[,] ButtonValue = new int[150, 150];
        int[,] visit = new int[150, 150];
        int ButonyAdeti = 0 , ButonxAdeti = 0, butonsayisi=0;
        FormWindowState LastWindowState = FormWindowState.Minimized;
        Random Rand = new Random();
        int ResetButton = 0, RemainingBomb = 0,RemainingField=0;
        double Score = 0;

        private void ComboBoxFill()
        {
            ComboBoxLeft.Items.Clear();
            ComboBoxRight.Items.Clear();
            for (int i = panelGamePlace.Height / 90; i <= panelGamePlace.Height / 45; i++)
                ComboBoxLeft.Items.Add(i);
            for (int i = panelGamePlace.Width / 90; i <= panelGamePlace.Width / 45; i++)
                ComboBoxRight.Items.Add(i);
            ComboBoxLeft.SelectedIndex = 0;
            ComboBoxRight.SelectedIndex = 0;
        }

        private void ComboBoxBombChange()
        {
            ComboBoxBomb.Items.Clear();
            int adet = Convert.ToInt32(ComboBoxLeft.Text) * Convert.ToInt32(ComboBoxRight.Text);
            int first = 0, second = 4;
            if (adet < 84) first = 7;
            else if (adet < 240) first = 12;
            else
            {
                first = 20;
                second = 5;
            }
            for (int i = adet / first; i < adet / second; i++)
                ComboBoxBomb.Items.Add(i);
            ComboBoxBomb.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width + 15, Screen.PrimaryScreen.Bounds.Height - 25);           
            buttonStart.Location = new System.Drawing.Point(this.Width - 130,7);
            ComboBoxBombChange();
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            buttonStart.Location = new System.Drawing.Point(this.Size.Width - 130, 7);
            //FULLSCREEN FIX
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized)
                    ComboBoxFill();
                if (WindowState == FormWindowState.Normal)
                    ComboBoxFill();
            }

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ComboBoxFill();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxRight.Text != "")
                ComboBoxBombChange();          
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLeft.Text != "")
                ComboBoxBombChange();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (ResetButton == 0)
            {
                label4.Text = "Score : " + Score;
                //ALL BUTON DELETE
                for (int i = 0; i < buttonArray.GetLength(0); i++)
                    for (int j = 0; j < buttonArray.GetLength(1); j++)
                    {
                        this.panelGamePlace.Controls.Remove(buttonArray[i, j]);  //Butonları Silme
                        ButtonValue[i, j] = 0;                                  //Bombaları Sıfırlama
                        visit[i, j] = 0;                                        //Ziyaret Edilenleri Sıfırlama
                    }
                //BUTON SIZE AND SPACE CALCULATE
                ButonxAdeti = Convert.ToInt32(ComboBoxRight.Text);
                ButonyAdeti = Convert.ToInt32(ComboBoxLeft.Text);
                butonsayisi = ButonxAdeti * ButonyAdeti;
                int butonboyut = 0;
                int butonboyutux = (panelGamePlace.Width - 5 - ButonxAdeti * 5) / ButonxAdeti;
                int butonboyutuy = (panelGamePlace.Height - 5 - ButonyAdeti * 5) / ButonyAdeti;
                if (butonboyutuy > butonboyutux) butonboyut = butonboyutux;
                else butonboyut = butonboyutuy;
                int sinirx = (panelGamePlace.Width - (butonboyut + 5) * ButonxAdeti + 5) / 2;
                int siniry = (panelGamePlace.Height - (butonboyut + 5) * ButonyAdeti + 5) / 2;

                //BOMB LOCATION FOUND
                for (int i = 0; i < Convert.ToInt32(ComboBoxBomb.Text); i++)
                {
                    int Bx = Rand.Next(0, ButonyAdeti);
                    int By = Rand.Next(0, ButonxAdeti);
                    if (ButtonValue[Bx, By] != -1) ButtonValue[Bx, By] = -1;
                    else i -= 1;
                }

                //CREATE GAME PLACE AND BUTTON SETINGS
                for (int i = 0; i < ButonyAdeti; i++)
                    for (int j = 0; j < ButonxAdeti; j++)
                    {
                        buttonArray[i, j] = new Button();
                        buttonArray[i, j].Size = new Size(butonboyut, butonboyut);
                        buttonArray[i, j].Font = new System.Drawing.Font("Nirmala UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        buttonArray[i, j].Name = i + " " + j + " ";
                        buttonArray[i, j].MouseDown += button_Click;
                        buttonArray[i, j].Location = new System.Drawing.Point(sinirx + butonboyut * j + 5 * j, siniry + butonboyut * i + 5 * i);
                        panelGamePlace.Controls.Add(buttonArray[i, j]);
                    }

                //Button Number Found
                int counter = 0;
                for (int i = 0; i < ButonyAdeti; i++)
                    for (int j = 0; j < ButonxAdeti; j++)
                    {
                        if (ButtonValue[i, j] != -1)
                        {
                            if (i != 0 && j != 0)
                                if (ButtonValue[i - 1, j - 1] == -1)
                                    counter += 1;
                            if (i != 0)
                                if (ButtonValue[i - 1, j] == -1)
                                    counter += 1;
                            if (i != 0 && j != ButonxAdeti - 1)
                                if (ButtonValue[i - 1, j + 1] == -1)
                                    counter += 1;
                            if (j != 0)
                                if (ButtonValue[i, j - 1] == -1)
                                    counter += 1;
                            if (j != ButonxAdeti - 1)
                                if (ButtonValue[i, j + 1] == -1)
                                    counter += 1;
                            if (i != ButonyAdeti - 1 && j != 0)
                                if (ButtonValue[i + 1, j - 1] == -1)
                                    counter += 1;
                            if (i != ButonyAdeti - 1)
                                if (ButtonValue[i + 1, j] == -1)
                                    counter += 1;
                            if (i != ButonyAdeti - 1 && j != ButonxAdeti - 1)
                                if (ButtonValue[i + 1, j + 1] == -1)
                                    counter += 1;
                            ButtonValue[i, j] = counter;
                            counter = 0;
                        }
                        buttonArray[i, j].BackColor = Color.LightBlue;
                    }
                buttonStart.Text = "RePlay";
                ResetButton = 1;
                ComboBoxLeft.Enabled = false;
                ComboBoxRight.Enabled = false;
                ComboBoxBomb.Enabled = false;
                RemainingBomb = Convert.ToInt32(ComboBoxBomb.Text);
                label3.Text = "Left Bomb Number : " + RemainingBomb.ToString();
                RemainingField = butonsayisi;
            }
            else
            {
                GameOver();
                Score = 0;
            }
        }

        private void HackMode()
        {
            for (int i = 0; i < ButonyAdeti; i++)
                for (int j = 0; j < ButonxAdeti; j++)
                {
                    buttonArray[i, j].Text = ButtonValue[i, j].ToString();
                }
        }

        private void FloodFillCheck(int butonx, int butony)
        {
            if (ButtonValue[butonx, butony] != -1 && visit[butonx, butony] != 1)
            {
                if (buttonArray[butonx, butony].BackColor == Color.Bisque)
                {
                    buttonArray[butonx, butony].BackgroundImage = null;
                    RemainingField++;
                    RemainingBomb++;
                    label3.Text = "Left Bomb Number : " + RemainingBomb.ToString();
                }
                if (ButtonValue[butonx, butony] == 0)
                {
                    
                    buttonArray[butonx, butony].BackColor = Color.Chocolate;
                    visit[butonx, butony] = 1;
                    RemainingField--;
                    FloodFill(butonx, butony);                    
                }
                else
                {
                    buttonArray[butonx, butony].BackColor = Color.Green;
                    visit[butonx, butony] = 1;
                    RemainingField--;
                }
                buttonArray[butonx, butony].Text = ButtonValue[butonx, butony].ToString();
                Score += (Convert.ToInt32(ComboBoxBomb.Text) * 100) / (butonsayisi * 10) * (ButtonValue[butonx, butony] + 1)*10;
            }
        }

        private void FloodFill(int butonx,int butony)
        {
            //FLOODFILL ALGORITHM   
            if (ButtonValue[butonx, butony] == 0)
            {
                if (ButtonValue[butonx, butony] == 0 && visit[butonx, butony] != 1)
                {
                    if (buttonArray[butonx, butony].BackColor == Color.Bisque)
                    {
                        buttonArray[butonx, butony].BackgroundImage = null;
                        RemainingField++;
                        RemainingBomb++;
                        label3.Text = "Left Bomb Number : " + RemainingBomb.ToString();
                    }
                    buttonArray[butonx, butony].BackColor = Color.Chocolate;
                    visit[butonx, butony] = 1;
                    RemainingField--;
                    Score += (Convert.ToDouble(ComboBoxBomb.Text) ) / (Convert.ToDouble(butonsayisi) ) * (ButtonValue[butonx, butony] + 1) * 1000;
                }
                //UP
                if (butonx != 0)
                {
                    FloodFillCheck(butonx - 1, butony);
                }
                //LEFT
                if (butony != 0)
                {
                    FloodFillCheck(butonx, butony - 1);
                }
                //DOWN
                if (butonx != ButonyAdeti - 1)
                {
                    FloodFillCheck(butonx + 1, butony);
                }
                //RIGHT
                if (butony != ButonxAdeti - 1)
                {
                    FloodFillCheck(butonx, butony + 1);
                }                
                buttonArray[butonx, butony].Text = ButtonValue[butonx, butony].ToString();
            }
            else if (ButtonValue[butonx, butony] == -1)
            {
                buttonArray[butonx, butony].BackColor = Color.Red;
                buttonArray[butonx, butony].BackgroundImage = WindowsFormsApp4.Properties.Resources.Mine;
                buttonArray[butonx, butony].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                GameOver();
            }
            else if(visit[butonx, butony] != 1)
            {
                buttonArray[butonx, butony].BackColor = Color.Green;
                buttonArray[butonx, butony].Text = ButtonValue[butonx, butony].ToString();
                visit[butonx, butony] = 1;
                RemainingField--;
                Score += (Convert.ToDouble(ComboBoxBomb.Text)) / (Convert.ToDouble(butonsayisi)) * (ButtonValue[butonx, butony] + 1) * 1000;
            }
        }

        private void GameOver()
        {
            label4.Text = "Score : " + Convert.ToInt32(Score).ToString();
            MessageBox.Show("GAME OVER");
            for (int i = 0; i < ButonyAdeti; i++)
                for (int j = 0; j < ButonxAdeti; j++)
                {
                    label4.Text = "Score : " + Convert.ToInt32(Score).ToString();
                    if (buttonArray[i, j].BackColor == Color.Bisque)
                    {
                        if (ButtonValue[i, j] == -1)
                        {
                            buttonArray[i, j].BackColor = Color.Red;
                            Score += ((Convert.ToDouble(ComboBoxBomb.Text)) / (butonsayisi)) * 2000;
                            
                        }
                        else
                        {
                            buttonArray[i, j].BackColor = Color.Yellow;
                            buttonArray[i, j].Text = ButtonValue[i, j].ToString();
                            buttonArray[i, j].BackgroundImage = null;
                        }
                    }
                    else
                    {
                        if (buttonArray[i, j].BackColor == Color.Green)
                            Score += (Convert.ToInt32(ComboBoxBomb.Text) + butonsayisi) * 3;
                        else if(buttonArray[i, j].BackColor == Color.Chocolate)
                            Score += (Convert.ToInt32(ComboBoxBomb.Text) + butonsayisi) * 3;
                        if (ButtonValue[i, j] == 0)
                        {
                            buttonArray[i, j].BackColor = Color.Chocolate;
                            buttonArray[i, j].Text = ButtonValue[i, j].ToString();
                        }
                        else if (ButtonValue[i, j] == -1)
                        {
                            buttonArray[i, j].BackColor = Color.Red;
                            buttonArray[i, j].BackgroundImage = WindowsFormsApp4.Properties.Resources.Mine;
                            buttonArray[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                        }
                        else
                        {
                            buttonArray[i, j].BackColor = Color.Green;
                            buttonArray[i, j].Text = ButtonValue[i, j].ToString();
                        }
                    }
                }
            buttonStart.Text = "Start";
            ComboBoxLeft.Enabled = true;
            ComboBoxRight.Enabled = true;
            ComboBoxBomb.Enabled = true;
            ResetButton = 0;
            Score = 0;
        }

        //BUTTON CLICK CODE

        private void button_Click(object sender, MouseEventArgs  e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //x and y
                string butonadi = (sender as Button).Name;
                int butonx = 0, butony = 0;
                int controller = 0;
                for (int i = 0; i < butonadi.Length; i++)
                    if (controller == 0)
                        if (butonadi[i] == ' ')
                            controller += 1;
                        else
                            if (butonadi[i + 1] == ' ')
                            butonx += Convert.ToInt32(butonadi[i].ToString());
                        else
                            butonx += Convert.ToInt32(butonadi[i].ToString()) * 10;
                    else
                        if (butonadi[i] == ' ')
                        controller += 1;
                    else
                            if (butonadi[i + 1] == ' ')
                        butony += Convert.ToInt32(butonadi[i].ToString());
                    else
                        butony += Convert.ToInt32(butonadi[i].ToString()) * 10;
                if (buttonArray[butonx, butony].BackColor == Color.LightBlue)
                {
                    FloodFill(butonx, butony);
                }
                label4.Text = "Score : " + Convert.ToInt32(Score).ToString();
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
                //x and y bulucu
                int controller = 0;
                string butonadi = (sender as Button).Name;
                int butonx = 0, butony = 0;
                for (int i = 0; i < butonadi.Length; i++)
                    if (controller == 0)
                        if (butonadi[i] == ' ')
                            controller += 1;
                        else
                            if (butonadi[i + 1] == ' ')
                            butonx += Convert.ToInt32(butonadi[i].ToString());
                        else
                            butonx += Convert.ToInt32(butonadi[i].ToString()) * 10;
                    else
                        if (butonadi[i] == ' ')
                        controller += 1;
                    else
                            if (butonadi[i + 1] == ' ')
                        butony += Convert.ToInt32(butonadi[i].ToString());
                    else
                        butony += Convert.ToInt32(butonadi[i].ToString()) * 10;

                if (buttonArray[butonx, butony].BackColor == Color.LightBlue)
                {
                    if (RemainingBomb > 0)
                    {
                        buttonArray[butonx, butony].BackColor = Color.Bisque;
                        buttonArray[butonx, butony].BackgroundImage = WindowsFormsApp4.Properties.Resources.Explosive;
                        buttonArray[butonx, butony].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                        buttonArray[butonx, butony].MouseDown += null;
                        RemainingBomb--;
                        RemainingField--;
                    }
                }
                else if (buttonArray[butonx, butony].BackColor == Color.Bisque)
                {
                    buttonArray[butonx, butony].BackColor = Color.LightBlue;
                    buttonArray[butonx, butony].BackgroundImage = null;
                    RemainingBomb++;
                    RemainingField++;
                }
                label3.Text = "Left Bomb Number : " + RemainingBomb.ToString();
            }
            if (RemainingField == 0)
            {
                MessageBox.Show("Perfect");
                Score += Convert.ToInt32(ComboBoxBomb.Text)*Convert.ToInt32(ComboBoxBomb.Text)*butonsayisi;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            HackMode();
        }
    }
}
