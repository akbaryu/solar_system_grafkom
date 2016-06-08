
using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using ShadowEngine;

namespace SistemaSolar
{
    class Satellite
    {
        Planets tipo;
        Position planetaPos;
        Position lunaPos;
        float anguloRotacion;
        float angulOrbitaPlaneta;
        float radio;
        int list;
        float velocidadOrbita;
        string texture;


        public Satellite(float radio, Planets tipo, Position posicion, string texture)
        {
            this.radio = radio;
            this.tipo = tipo;
            planetaPos = posicion;
            lunaPos = planetaPos;
            lunaPos.x += 3; 
            //velocidadOrbita = (float)r.NextDouble() * 0.3f;
            this.texture = texture; 
        }

        public void Create()
        {
            Glu.GLUquadric quadratic = Glu.gluNewQuadric();
            Glu.gluQuadricNormals(quadratic, Glu.GLU_SMOOTH);
            Glu.gluQuadricTexture(quadratic, Gl.GL_TRUE);

            list = Gl.glGenLists(1);
            Gl.glNewList(list, Gl.GL_COMPILE);
            Gl.glPushMatrix();
            Gl.glRotated(90, 1, 0, 0);
            Glu.gluSphere(quadratic, radio, 32, 32);
            Gl.glPopMatrix();
            Gl.glEndList();
        }

        public void Paint(Position p,float anguloOrbita)
        {
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName(texture));
            
            anguloOrbita += velocidadOrbita;
            anguloRotacion += 0.6f;
            angulOrbitaPlaneta += 0.6f;
            Gl.glPushMatrix();
            Gl.glRotatef(anguloOrbita, 0, 1, 0);
            Gl.glTranslatef(-p.x, -p.y, -p.z);
            Gl.glRotatef(angulOrbitaPlaneta, 0, 1, 0);
            Gl.glTranslatef(2, 0, 0);
            Gl.glRotatef(anguloRotacion, 0, 1, 0);
            Gl.glCallList(list);
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);  
        } 
    }
}
