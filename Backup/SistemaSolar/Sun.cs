/* 
 *This code is property of Vasily Tserekh
 *if you like it you can visit my personal dev blog
 *http://vasilydev.blogspot.com
*/

using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using ShadowEngine; 

namespace SistemaSolar
{
    class Sun
    {
        //clase en cargada de dibujar el cielo        
        int list;
        float rotacion;

        public void Create()
        {
            Glu.GLUquadric quadratic = Glu.gluNewQuadric();
            Glu.gluQuadricNormals(quadratic, Glu.GLU_SMOOTH);
            Glu.gluQuadricTexture(quadratic, Gl.GL_TRUE);

            list = Gl.glGenLists(1);
            Gl.glNewList(list, Gl.GL_COMPILE);
            Gl.glPushMatrix();
            Gl.glRotated(90, 1, 0, 0);
            //Gl.glDisable(Gl.GL_LIGHTING);
            Glu.gluSphere(quadratic, 3, 32, 32);
            //Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glPopMatrix();
            Gl.glEndList();
        }

        public  void Paint()
        {
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("sol.jpg"));   
            Gl.glPushMatrix();
            rotacion += 0.05f; 
            Gl.glRotatef(rotacion, 0, 1, 0);  
            Gl.glCallList(list);
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D); 
        } 
    }
}
