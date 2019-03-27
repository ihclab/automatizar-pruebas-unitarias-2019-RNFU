using System;
using System.IO;

namespace AutomatizarPruebasUnitarias {
    public class Program {
        public static void Main(string[] args) {
            string[] pruebas = File.ReadAllLines("CasosPrueba.txt");
            foreach (var prueba in pruebas) {
                string[] casos = prueba.Split(':');
                 
                string[] nums = casos[2].Split(' ');
                int[] parametros = new int[nums.Length];
                
                try {
                    for(int i = 0; i < parametros.Length; i++) {
                        parametros[i] = int.Parse(nums[i]);
                    }
                } catch (Exception ex) {
                    if (casos[2] == "NULL")
                        parametros = null;
                }
            }
        }
    }
}