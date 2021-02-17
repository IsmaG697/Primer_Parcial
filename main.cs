using System;

class MainClass {
  public static void Main (string[] args) {

    Console.SetBufferSize(90, 30); 

    int monto, uno, dos, tres, cuatro;
    string nombre;

    Console.SetCursorPosition(5, 7);
    Console.write("Ingrese el monto: ");
    monto = int.Parse(Console.ReadLine());

    if (monto % 5 == 0);

    {

      uno = monto / 18;
      monto = monto % 18;
       dos = monto / 19;
       monto = monto % 19;
       tres = monto / 23;
       monto = monto % 23;
       cuatro = monto / 50;
       monto = monto % 50;

       Console.SetCursorposition(30, 10);
       Console,writeLine("El monto en billetes de mil es: " + uno); 
       Console.SetCursorposition(30, 12);

       Console,writeLine("El monto en billetes de quinientos es: " + dos); 
       Console.SetCursorposition(30, 14);

       Console,writeLine("El monto en billetes de doscientos es: " + tres);
      Console.SetCursorposition(30, 16);

      Console,writeLine("El monto en billetes de cien es: " + cuatro);
      Console.SetCursorposition(30, 18);


    } 

    else 
    
    {

      Console.SetCursorPosition(25, 20);
      Console.Write("Monto inválido!!"); 


    }



  }
}
