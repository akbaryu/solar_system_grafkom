
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShadowEngine;
using ShadowEngine.OpenGL;
using Tao.OpenGl;

namespace SistemaSolar
{
    public partial class MainForm : Form
    {
        //handle del viewport
        uint hdc;
        SolarSystem sistema = new SolarSystem();
        static bool showOrbit = true;
        static bool status = true;
        static Vector2 formPos;
        int moviendo;

        public static Vector2 FormPos
        {
            get { return MainForm.formPos; }
            set { MainForm.formPos = value; }
        }

        public static bool ShowOrbit
        {
            get { return MainForm.showOrbit; }
            set { MainForm.showOrbit = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            hdc = (uint)pnlViewPort.Handle;
            string error = "";
            //Comando de inicializacion de la ventana grafica
            OpenGLControl.OpenGLInit(ref hdc, pnlViewPort.Width, pnlViewPort.Height, ref error);
            //inicia la posicion de la camara asi como define en angulo de perspectiva,etc etc

            if (error != "")
            {
                MessageBox.Show(error);
            }

            sistema.Camara.InitCamara();
            //Habilita las luces


            float[] materialAmbient = { 0.5F, 0.5F, 0.5F, 1.0F };
            float[] materialDiffuse = { 1f, 1f, 1f, 1.0f };
            float[] materialSpecular = { 1.0F, 1.0F, 1.0F, 1.0F };
            float[] materialShininess = { 10.0F }; // brillo 
            float[] ambientLightPosition = { 0F, 0F, 0F, 1.0F }; // posicion
            float[] lightAmbient = { 0.85F, 0.85F, 0.85F, 0.0F }; // intensidad de la luz

            Lighting.MaterialAmbient = materialAmbient;
            Lighting.MaterialDiffuse = materialDiffuse;
            Lighting.MaterialShininess = materialShininess;
            Lighting.AmbientLightPosition = ambientLightPosition;
            Lighting.LightAmbient = lightAmbient;

            Lighting.SetupLighting();

            //cargar texturas
            ContentManager.SetTextureList("texturas\\");
            ContentManager.LoadTextures();
            sistema.CreateScene();
            Camara.CenterMouse();
            //Color de fondo
            Gl.glClearColor(0, 0, 0, 1);//red green blue alpha 
        }

        private void tmrPaint_Tick(object sender, EventArgs e)
        {

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            sistema.Camara.Update(moviendo);

            sistema.DrawScene();

            Winapi.SwapBuffers(hdc);

            Gl.glFlush();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            formPos = new Vector2(this.Left, this.Top);
        }

        private void pnlViewPort_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moviendo = 1;
            }
            else
            {
                moviendo = -1;
            }

        }

        private void pnlViewPort_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = 0;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Menu a = new Menu();
                a.Show();
            }
                if (e.KeyCode == Keys.W)
            {
                if (status == true)
                {
                    panel2.Hide();
                    status = false;
                }
                else if (status == false)
                {
                    panel2.Show();
                    status = true;
                }
            }
            if (e.KeyCode == Keys.O)
            {
                if (showOrbit == true)
                    showOrbit = false;
                else
                    showOrbit = true;
            }
        }
    }
}
