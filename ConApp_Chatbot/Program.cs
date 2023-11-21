using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Chatbot
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hola, ¿cómo te llamas?");//1
                string nombre = Console.ReadLine();
                Console.WriteLine("Hola " + nombre + " Que tal estas?");//2
                estado:
                string estado = Console.ReadLine();

                if (estado.Contains("bien") || estado.Contains("Bien"))
                {
                    Console.WriteLine("Me alegro que este bien, yo también lo estoy");

                }
                else if (estado.Contains("mal") || estado.Contains("Mal"))
                {
                    Console.WriteLine("¿Por que estas o te sientes mal?");//3
                    string razon = Console.ReadLine();
                    Console.WriteLine("Espero de verdad que esa situación mejore");
                }
                else
                {
                    Console.WriteLine("Perdona no te entendí, ¿me repites tu respuesta?");

                    goto estado;
                }
                Console.WriteLine("¿Que te gusta más comer o dormir?");//4
                gusto:
                string gusto = Console.ReadLine();
                if (gusto.Contains("Comer") || gusto.Contains("comer"))
                {
                    Console.WriteLine("Te entiendo comer es un gran placer");
                    Console.WriteLine("Y ¿qué comidas prefieres la de la sierra o la costa?");//5
                    string comida = Console.ReadLine();
                    if (comida.Contains("Sierra") || comida.Contains("sierra"))
                    {
                        Console.WriteLine("¿Que plato de la sierra te gusta más?");//6
                        string coms = Console.ReadLine();
                        Console.WriteLine("El " + coms + " es muy rico!");
                    }else if(comida.Contains("Costa") || comida.Contains("costa"))
                    {
                        Console.WriteLine("¿Que plato de la costa te gusta más?");//7
                        string comc = Console.ReadLine();
                        Console.WriteLine("El " + comc + " es muy rico!");
                    }
                }else if (gusto.Contains("Dormir") || gusto.Contains("dormir"))
                {
                    Console.WriteLine("Te entiendo dormir es uno de los grandes placeres de la vida");
                }
                else
                {
                    Console.WriteLine("Perdona no te entendí, ¿me repites tu respuesta?");

                    goto gusto;
                }
                Console.WriteLine("¿Que te gusta mas los gatos o los perros?");//8
                mascota:
                string agus = Console.ReadLine();
                if (agus.Contains("perros") || agus.Contains("Perros") || agus.Contains("perro") || agus.Contains("Perro"))
                {
                    Console.WriteLine("A mi tambien me gustan los perros!, es que son muy agradables");
                }else if (agus.Contains("gatos") || agus.Contains("Gatos") || agus.Contains("gato") || agus.Contains("Gato"))
                {
                    Console.WriteLine("Los gatos geniales, pero soy más de perros");
                }
                else 
                {
                    Console.WriteLine("Perdona no te entendí, ¿me repites tu respuesta?");

                    goto mascota;
                }
                Console.WriteLine("¿Cuál es tu color favorito?");//9
                string color = Console.ReadLine();
                if(color.Contains("Rojo") || color.Contains("rojo"))
                {
                    Console.WriteLine("Mi color favorito también es el " + color);
                }
                else
                {
                    Console.WriteLine("El "+color+" es un color bonito");
                }
                

                Console.WriteLine("¿Qué te gusta hacer en tu tiempo libre?");//10
                string tiempoLibre = Console.ReadLine();
                if(tiempoLibre.Contains("jugar futbol")|| tiempoLibre.Contains("ver futbol")|| tiempoLibre.Contains("jugar pelota")|| tiempoLibre.Contains("utbol")|| tiempoLibre.Contains("elota"))
                {
                    Console.WriteLine("A mi también me gusta " + tiempoLibre + " en mi tiempo libre");
                }
                else
                {
                    Console.WriteLine(tiempoLibre + " es una actividad interesante");
                }
                

                Console.WriteLine("¿Cuál es tu pasatiempo favorito?");//11
                string pasatiempo = Console.ReadLine();
                if(pasatiempo.Contains("musica")|| pasatiempo.Contains("Musica")|| pasatiempo.Contains("usíca"))
                {
                    Console.WriteLine("Mi pasatiempo favorito también es  " + pasatiempo);
                    Console.WriteLine("¿Cuál es tu música favorita?");//12
                    string musica = Console.ReadLine();
                    
                    Console.WriteLine("Wow tienes buenos gustos");

                    Console.WriteLine("¿Cuál es tu cantante favorito?");//13
                    string artista = Console.ReadLine();
                    Console.WriteLine(artista+ ", hace buena música");

                    Console.WriteLine("¿Cuál es tu banda favorita?");//14
                    string banda = Console.ReadLine();
                    Console.WriteLine("No conozco la banda "+banda+ ", me gustaría escucharlos");
                }
                else
                {
                    Console.WriteLine("Interesante, a mí me gusta escuchar música");
                }
                

                Console.WriteLine("¿Cuál es tu película favorita?");//15
                string pelicula = Console.ReadLine();
                if(pelicula.Contains("Titanes del pacífico")|| pelicula.Contains("titanes del pacífico"))
                {
                    Console.WriteLine("Esa también es mi película favorita," + pelicula+ " es la mejor película de ciencia ficción");
                }
                else
                {
                    Console.WriteLine("Esa película es muy buena ");
                }
                

                Console.WriteLine("¿Cuál es tu libro favorito?");//16
                string libro = Console.ReadLine();
                if( libro.Contains("no leo")|| libro.Contains("No leo"))
                {
                    Console.WriteLine("Jaja, yo tampoco");
                }
                else
                {
                    Console.WriteLine("No sé de qué trata pero suena bueno");
                }
                

                
                // Preguntas nuevas

                Console.WriteLine("¿Cuál es tu deporte favorito?");//17
                string deporte = Console.ReadLine();
                if (deporte.Contains("utbol")|| deporte.Contains("útbol"))
                {
                    Console.WriteLine("Que bien hablemos de eso");
                    

                    Console.WriteLine("¿Cuál es tu equipo favorito?");//18
                    string equipoDeportivo = Console.ReadLine();
                    Console.WriteLine("El " + equipoDeportivo+" es un equipo bueno");

                    Console.WriteLine("¿Cuál es tu jugador favorito?");//19
                    string jugadorDeportivo = Console.ReadLine();
                    if (jugadorDeportivo.Contains("essi"))
                    {
                        Console.WriteLine("Ese es el mejor jugador de la historia ");
                    }
                    else
                    {
                        Console.WriteLine("Es un jugador bueno pero el mejor es Messi");
                    }

                }
                else
                {
                    Console.WriteLine("Suena a que es un gran deporte");
                }
                

                Console.WriteLine("¿Cuál es tu ciudad favorita?");//20
                string ciudad = Console.ReadLine();
                Console.WriteLine("Esa ciudad es genial" );

                

                // Salida

                Console.WriteLine("Gracias por responder mis preguntas, " + nombre + ". Fue un placer conocerte.");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Oh no! algo salió mal: " + ex.ToString());
            }
            



        }
    }
}

