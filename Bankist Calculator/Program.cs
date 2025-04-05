printText("**********- Welcome -***********");

int option = 0;



while(option != -1) {

displayMenu();

string selectedValue = inputString();

//procesing user input

userRequest(selectedValue);

}

//adding menu options
void displayMenu()
{
    printText("--Elige una option y presiona enter--");
    string[] options = ["1:couta nivelada", "2:couta sobre saldo", "3:extra-financimiento"];

    foreach (var item in options)
    {
        printText(item);
    }

}

//adding helpers methods
void printText(string s)
{
    Console.WriteLine(s);

}

string inputString()
{
    var inputS = Console.ReadLine();

    return inputS;
}

//user requet

void userRequest(string selected)
{
    switch (selected)
    {
        case "1":
            printText("Elecion: couta nivelada");
            coutaNivelada();

            break;
        case "2":
            printText("Elecion: couta sobre saldo");
            break;
        case "3":
            printText("Elecion: extra-financimiento");
            break;
        default:
            printText("Ninguna option selecionada");
            break;
    }
}

//procesing calculations



void coutaNivelada()
{
    try
    {
        printText("ingresa el monto del prestamo sin puntos ni comas ejemplo: 25000");
        int montoPrestamo = Convert.ToInt32(inputString());
        printText("ingresa la tasa de interes mensual del prestamo sin puntos ni comas ejemplo: 2");
        int tasaMensual = Convert.ToInt32(inputString());
        printText("ingresa el plazo en meses sin puntos ni comas ejemplo: 36");
        int plazoMeses = Convert.ToInt32(inputString());
        calculateCoutaNivelada(montoPrestamo, tasaMensual, plazoMeses);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        
    }

}

//Monto del préstamo x Tasa de interés mensual / (1 - (1 + Tasa de interés mensual)^Plazo del crédito en meses) 
void calculateCoutaNivelada(int monto, int tasa, int plazo)
{
    double resultado = (monto * tasa) / (1 - (1 + tasa) ^ -plazo);

    printText($"el calculo para tu prestamo es: {resultado}");
}
