using System;
using System.IO;

namespace AutomatizarPruebasUnitarias {
    public class Main {
        public static void Main(string[] args) {
            string[] pruebas = File.ReadAllLines("CasosPruebas.txt");
            foreach (var prueba in pruebas) {
                string[] casos = prueba.Split(':');
            }
        }
    }
}