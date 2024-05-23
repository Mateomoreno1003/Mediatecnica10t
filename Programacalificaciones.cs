/******************************************************************************
Auto: Mateo Moreno
fecha: 2024-05-23
Descripcion:
         Un docente requiere de un sistema de notas done recibe 4 calificacionjes 
         generando un promedio y luego determinando si gana o pierde.
         si su promedio es menor a 3 pierde
         si es mayor gana
         si tiene un promedio mayor a 4.5 emitir mensaje:"felicidades, te has 
         ganado una beca"

*******************************************************************************/
using System;
class ProgramaCalificaciones{
  static void Main() {
      
      //  declaracion de variables para las calificaciones
      double calificacion1, calificacion2, calificacion3, calificacion4;
      
     
      Console.WriteLine(" Ingrese la primera calificacion");
      calificacion1 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine(" Ingrese la segunda calificacion"); 
      calificacion2 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine(" Ingrese la tercera calificacion");
      calificacion3 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine(" Ingrese la cuarta calificacion");
      calificacion4 = Convert.ToDouble(Console.ReadLine());
      
      // calcular el promedio
      double promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4 ) / 4;
      
      // mostrar el promedio
      Console.WriteLine("El promedio es: " + promedio);
      
      if (promedio < 2.99){
          Console.WriteLine("Perdiste 🤣🤣🤣 , vuelve a intentarlo");
          
      }
      
      if(promedio >= 3 ){
          Console.WriteLine("Ganaste 👍👍👍");
      }
      
      if(promedio >= 4.5){
         Console.WriteLine("Felicidades, te acabas de ganar una beca 👩‍🎓 👩‍🎓 👩‍🎓");
      }
      
      
          }
       }
       
