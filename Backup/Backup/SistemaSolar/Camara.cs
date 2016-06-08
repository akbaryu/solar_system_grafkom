/* 
 *This code is property of Vasily Tserekh
 *if you like it you can visit my personal dev blog
 *http://vasilydev.blogspot.com
*/

using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using System.Drawing;

namespace SistemaSolar
{
    public class Camara
    {
        #region Camera constants
        
        const double div1 = Math.PI / 180;
        const double div2 = 180 / Math.PI;
        
        #endregion 
        
        #region Private atributes

        static float eyex, eyey, eyez;
        static float centerx, centery, centerz;
        static float forwardSpeed = 0.3f;
        static float yaw, pitch;
        static float rotationSpeed = 0.25f;
        static double i, j, k;

        #endregion

        public static float Pitch
        {
            get { return Camara.pitch; }
            set { Camara.pitch = value; }
        }

        public static float Yaw
        {
            get { return Camara.yaw; }
            set { Camara.yaw = value; }
        }

        public void InitCamara()
        {
            eyex = 0f;
            eyey = 2f;
            eyez = 5f;
            centerx = 0;
            centery = 2;
            centerz = 0; 
            Look();
        }

        public void Look()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(eyex, eyey, eyez, centerx, centery, centerz, 0, 1, 0);
        }

        static public float AnguloARadian(double pAngle)
        {
            return (float)(pAngle * div1);
        }

        static public float RadianAAngulo(double pAngle)
        {
            return (float)(pAngle * div2);
        }

        public void UpdateDirVector()
        {
            k = Math.Cos(AnguloARadian((double)yaw)); //eje z
            i = -Math.Sin(AnguloARadian((double)yaw)); // eje x
            j = Math.Sin(AnguloARadian((double)pitch)); // eje y      
            
            centerz = eyez - (float)k; // calcula a donde esta mirando la camara 
            centerx = eyex - (float)i;
            centery = eyey - (float)j;
        }

        public static void CenterMouse()
        {
            Winapi.SetCursorPos(MainForm.FormPos.X + 512, MainForm.FormPos.Y + 384);   
        }

        public void Update(int pressedButton)
        {
            #region Aim camera

                Pointer position = new Pointer();
                Winapi.GetCursorPos(ref position);   

                int difX = MainForm.FormPos.X + 512 - position.x;
                int difY = MainForm.FormPos.Y + 384 - position.y;

                if (position.y < 384)
                {
                    pitch -= rotationSpeed * difY;
                }
                else
                    if (position.y > 384)
                    {
                        pitch += rotationSpeed * -difY;
                    }
                if (position.x < 512)
                {
                    yaw += rotationSpeed * -difX;
                }
                else
                    if (position.x > 512)
                    {
                        yaw -= rotationSpeed * difX;
                    }
                UpdateDirVector();
                CenterMouse();


                if (pressedButton == 1) // se apreto el boton izquierdo de mouse
                {
                    eyex -= (float)i * forwardSpeed;
                    eyey -= (float)j * forwardSpeed;
                    eyez -= (float)k * forwardSpeed;      
                }
                else
                    if (pressedButton == -1) // se apreto el boton derecho del mouse
                    {
                        eyex += (float)i * forwardSpeed;
                        eyey += (float)j * forwardSpeed;
                        eyez += (float)k * forwardSpeed;
                    }

            #endregion

            Look();  
        }
    }
}
