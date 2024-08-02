using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using JPUtil;

namespace Travesía_por_la_jungla
{
    public partial class Introducir : Form
    {
         
        Tablero tablero;
        Jugador[] jug;
        ColorTable junglaVisual;        
        
        

        public Introducir()
        {
            InitializeComponent();
        }

        #region CheckBox
        
        private void rbTresJugadores_CheckedChanged(object sender, EventArgs e)
        {
            this.lblJugThree.Visible = true;
            this.textBox3.Visible = true;
            this.lblJugFour.Visible = false;
            this.textBox4.Visible = false;
        }
                
        private void rbCuatroJugadores_CheckedChanged(object sender, EventArgs e)
        {
            this.lblJugThree.Visible = true;
            this.textBox3.Visible = true;
            this.lblJugFour.Visible = true;
            this.textBox4.Visible = true;
        }

        private void rbDosJugador_CheckedChanged(object sender, EventArgs e)
        {
            this.lblJugThree.Visible = false;
            this.textBox3.Visible = false;
            this.lblJugFour.Visible = false;
            this.textBox4.Visible = false;
        }
        #endregion

       
        Form1 f;
        private void btnAceptar_Click(object sender, EventArgs e)
        { 

                if (rbDosJugador.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrWhiteSpace(textBox1.Text)&&!string.IsNullOrEmpty(textBox2.Text)&&!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        if (lstTamaño.SelectedIndex == 0)
                        {
                            f = new Form1(10, 9, new Jugador[2], 8,textBox1.Text,textBox2.Text);
                            this.Visible = false;
                            f.ShowDialog();
                            this.Dispose();
                            this.Close();
                            f.Dispose();
                        }
                        else if (lstTamaño.SelectedIndex == 1)
                        {
                            f = new Form1(16, 15, new Jugador[2], 8, textBox1.Text, textBox2.Text);
                            this.Visible = false;
                            f.ShowDialog();
                            this.Dispose();
                            this.Close();
                            f.Dispose();
                        }
                        else if (lstTamaño.SelectedIndex == 2)
                        {
                            f = new Form1(20, 19, new Jugador[2], 8, textBox1.Text, textBox2.Text);
                            this.Visible = false;
                            f.ShowDialog();
                            this.Dispose();
                            this.Close();
                            f.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error:\n\n Inserte los nombres de ambos jugadores.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    

                }

                else
                {
                    if (rbTresJugadores.Checked)
                    {
                        if (!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrWhiteSpace(textBox1.Text)&&
                            !string.IsNullOrEmpty(textBox2.Text)&&!string.IsNullOrWhiteSpace(textBox2.Text)&&
                            !string.IsNullOrEmpty(textBox3.Text)&&!string.IsNullOrWhiteSpace(textBox3.Text))
                        {
                            if (lstTamaño.SelectedIndex == 0)
                            {
                                f = new Form1(10, 9, new Jugador[3], 10, textBox1.Text, textBox2.Text, textBox3.Text);
                                this.Visible = false;
                                f.ShowDialog();
                                this.Dispose();
                                this.Close();
                                f.Dispose();
                            }
                            else
                            {
                                if (lstTamaño.SelectedIndex == 1)
                                {
                                    f = new Form1(16, 15, new Jugador[3], 10, textBox1.Text, textBox2.Text, textBox3.Text);
                                    this.Visible = false;
                                    f.ShowDialog();
                                    this.Dispose();
                                    this.Close();
                                    f.Dispose();
                                }
                                else
                                {
                                    if (lstTamaño.SelectedIndex == 2)
                                    {
                                        f = new Form1(20, 19, new Jugador[3], 10, textBox1.Text, textBox2.Text, textBox3.Text);
                                        this.Visible = false;
                                        f.ShowDialog();
                                        this.Dispose();
                                        this.Close();
                                        f.Dispose();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error:\n\n Inserte los nombres de los tres jugadores.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                }

                if (rbCuatroJugadores.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrWhiteSpace(textBox1.Text)&&
                        !string.IsNullOrEmpty(textBox2.Text)&&!string.IsNullOrWhiteSpace(textBox2.Text)&&
                        !string.IsNullOrEmpty(textBox3.Text)&&!string.IsNullOrWhiteSpace(textBox3.Text)&&
                        !string.IsNullOrEmpty(textBox4.Text)&&!string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        if (lstTamaño.SelectedIndex == 0)
                        {
                            f = new Form1(10, 9, new Jugador[4], 13, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                            this.Visible = false;
                            f.ShowDialog();
                            this.Dispose();
                            this.Close();
                            f.Dispose();
                        }
                        else
                        {
                            if (lstTamaño.SelectedIndex == 1)
                            {
                                f = new Form1(16, 15, new Jugador[4], 13, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                                this.Visible = false;
                                f.ShowDialog();
                                this.Dispose();
                                this.Close();
                                f.Dispose();
                            }
                            else
                            {
                                if (lstTamaño.SelectedIndex == 2)
                                {
                                    f = new Form1(20, 19, new Jugador[4], 13, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                                    this.Visible = false;
                                    f.ShowDialog();
                                    this.Dispose();
                                    this.Close();
                                    f.Dispose();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error:\n\n Inserte los nombres de los cuatro jugadores.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                }          
        }     

        
        private void Introducir_Load(object sender, EventArgs e)
        {
            lstTamaño.SelectedIndex = 0;
        }

        #region Eventos KeyPress
        private void Introducir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnAceptar_Click(sender, new EventArgs());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar_Click(sender, new EventArgs());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar_Click(sender, new EventArgs());
            }
        }
        #endregion

        
        //public ArrayList

                  
    }
}
