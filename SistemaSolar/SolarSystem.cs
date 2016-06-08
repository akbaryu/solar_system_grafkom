

using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaSolar
{
    enum Planets
    {Mercury, Venus, Earth, Mars, Jupiter, Saturn, Neptune, Uranus, Pluton }


    public struct Position
    {
        public float x;
        public float y;
        public float z;

        public Position(int x,int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public class SolarSystem
    {
        Camara camara = new Camara();
        Star estrella = new Star();
        Sun sol = new Sun();
        List<Planet> planetas = new List<Planet>();
       

        public void CreateScene()
        {
            planetas.Add(new Planet(0.5f, Planets.Mercury, new Position(7, 4, 6), "bola.jpg",false));
            planetas.Add(new Planet(0.7f, Planets.Venus, new Position(11, 0, 0), "venus.jpg", false));
            planetas.Add(new Planet(1, Planets.Earth, new Position(15, 0, 0), "tierra.jpg", true));
            planetas.Add(new Planet(1, Planets.Mars, new Position(22, 0, 0), "marte.jpg", false));
            planetas.Add(new Planet(1.5f, Planets.Jupiter, new Position(28, 0, 0), "jupiter.jpg", false));
            planetas.Add(new Planet(1.2f, Planets.Saturn, new Position(35, 0, 0), "saturno.bmp", false));
            planetas.Add(new Planet(1.2f, Planets.Uranus, new Position(41, 0, 0), "urano.jpg", false));
            planetas.Add(new Planet(1.2f, Planets.Neptune, new Position(51, 0, 0), "restantes.jpg", false));
            planetas.Add(new Planet(1.2f, Planets.Pluton, new Position(60, 0, 0), "restantes.jpg", false));
            estrella.CreateStars(500);
            sol.Create();
            foreach (var item in planetas)
            {
                item.Create();  
            }
        }

        public Camara Camara
        {
            get { return camara; }
        }

        public void DrawScene()
        {  
            estrella.Draw();
            sol.Paint();
            foreach (var item in planetas)
            {
                item.Paint(); 
            }
        }
    }
}
