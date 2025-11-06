/* Hola, Axel, Ernesto, Andres o Itzel 
 * 
 * Al momento de realizar la entrevista no me di cuenta que venía un pseudocódigo para el desafio 1 tambien
 * 
 * Me hizo más sentido que solo viniera para el segundo ya que era el que teníamos que corregir
 * 
 * Pensaba que en el primero teníamos que hacerlo desde cero, que solo nos teníamos que enfocar en la salida, 
 * y que el único requisito era utilizar herencia y polimorfismo
 *
 * Igual como no se esperaba ninguna entrada no me preocupé mucho por hacerlo dinamico ni ponerle un constructor a cada clase por la misma razón
 * 
 * Este commit solo es para mostrar como lo hubiese hecho si teniendo en cuenta el pseudocódigo para este desafio 
 * 
 * Realmente lo unico que se cambió fue agregar los constructores para poder crear varios objetos de las formas y que podamos 
 * modificar sus campos al instanciar
 * 
 * 
 * Y al final ya que hayamos creado las instancias las guardamos en una lista
 * 
 * Y con un bucle foreach recorremos cada objeto y con el metodo getFormula, nos imprime su respectiva formula dependiendo de la forma que sea
 * 
 * Entiendo que la evaluación será con el código realizado durante la entrevista, y que mi código original cumple con todos los constrains establecidos
 * Solo quería aprovechar el repositorio para mostrar el código basado en el pseudocódigo
 *
 * En caso de causar confusiones para la evaluación hacer caso omiso a este archivo, el código que hice en la entrevista es el del archivo "Program.cs" 
 * que se encuentra al mimso nivel de este archivo
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HelloWorld;
namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Shape> listShapes = new List<Shape>();
            
            //Circle
            Circle objcircle = new Circle(5);

            
            
            //Rectangle
            Rectangle objRectangle = new Rectangle(5,5);
            

            //Triangle

            Triangle objTriangle = new Triangle(3,4);

            listShapes.Add(objcircle);
            listShapes.Add(objRectangle);
            listShapes.Add(objTriangle);

            foreach(Shape shape in listShapes)
            {
                Console.WriteLine(shape.getArea());
            }


        }


    }


    public class Shape
    {
        
        public virtual double getArea()
        {
            double formula = 0;

            return (formula);
        }


    }


    public class Circle : Shape

    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            
        }
        public override double getArea()
        {
            double formula;
            formula = 3.1416 * radius * radius;
            return (formula);
        }
    }


    public class Rectangle : Shape

    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double getArea()
        {
            double formula;
            formula = width * height;
            return (formula);
        }
    }


    public class Triangle : Shape

    {
        private double _base;
        private double height;

        
        public Triangle(double _base, double height)
        {
            this._base = _base;
            this.height = height;
        }

        public override double getArea()
        {
            double formula;
            formula = (_base * height) / 2;
            return (formula);
        }
    }

}