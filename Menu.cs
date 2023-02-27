using System;

namespace listas
{
    public class App {

    public static void Main(String[] args) {
        Console.WriteLine("=== LISTA DE EXERCÍCIOS: ===");

        Console.WriteLine("+-----------------+");
        Console.WriteLine("| 1 - Lista 1     |");
        Console.WriteLine("| 2 - Lista 2     |");
        Console.WriteLine("| 3 - Lista 3     |");
        Console.WriteLine("| 4 - Lista 4     |");
        Console.WriteLine("| 5 - Lista 5     |");
        Console.WriteLine("| 6 - Lista Extra |");
        Console.WriteLine("+-----------------+");

        int menu = 0;
        try {
            menu = Int32.Parse(Console.ReadLine());
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            menu = 0;
        }

        switch (menu) {
            // Lista 1
            case 1:
                ExercicioUm.call();
                break;
            // Lista 2
            case 2:
                ExercicioDois.call();
                break;
            // Lista 3
            case 3:
                ExercicioTres.call();
                break;
            // Lista 4
            case 4:
                ExercicioQuatro.call();
                break;
            // Lista 5
            case 5:
                ExercicioCinco.call();
                break;
            // Lista Extra
            case 6:
                //ExercicioExtra.call();
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
            }
        }
    }
}
