//PRACTICA DEL USO DE ESTRUCTURAS CONDICIONALES

//EJERCICIO #1 - CÁLCULAR EL MAYOR DE TRES NUMEROS
//**********************************************+*

using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("- - - CÁLCULAR EL MAYOR DE TRES NUMEROS - - - \n");
double ECnum1_1, ECnum1_2, ECnum1_3;

try
{
    Console.WriteLine("Ingrese el primer número: ");
    ECnum1_1 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo número: ");
    ECnum1_2 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el tercer número: ");
    ECnum1_3 = Convert.ToDouble(Console.ReadLine()!);

    if (ECnum1_1 >= ECnum1_2 && ECnum1_1 >= ECnum1_3)
    {
        Console.WriteLine("\nEl numero mayor es: " + ECnum1_1);
    }
    else if (ECnum1_2 >= ECnum1_1 && ECnum1_2 >= ECnum1_3)
    {
        Console.WriteLine("\nEl numero mayor es: " + ECnum1_2);
    }
    else if (ECnum1_3 >= ECnum1_1 && ECnum1_3 >= ECnum1_2)
    {
        Console.WriteLine("\nEl numero mayor es: " + ECnum1_3);
    }
    else
    {
        Console.WriteLine("Número invalido");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO #2 - VALIDAR EDAD PARA INGRESAR A UN CLUB
Console.WriteLine("- - - VALIDAR EDAD PARA INGRESAR A UN CLUB - - - \n");
int ECedad2_1;
try
{
    Console.WriteLine("Ingrese su edad:");
    ECedad2_1 = int.Parse(Console.ReadLine()!);

    if (ECedad2_1 >= 18)
    {
        Console.WriteLine("\nAdmitido\nBienvenido al Club");
    }

    else
    {
        Console.WriteLine("\nNo admitido\nUsted no cumple con la edad para entrar al club");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO #3 - CALCULAR EL PRECIO FINAL DE UN PRODUCTO
Console.WriteLine("- - - CALCULAR EL PRECIO FINAL DE UN PRODUCTO - - - \n");
double ECprecio_producto3_1, ECdescuento3_1, ECprecio_final3_1;
try
{
    Console.WriteLine("Ingrese el precio del producto");
    ECprecio_producto3_1 = Convert.ToDouble(Console.ReadLine()!);

    if (ECprecio_producto3_1 > 100)
    {
        ECdescuento3_1 = ECprecio_producto3_1 * 0.10;
        ECprecio_final3_1 = ECprecio_producto3_1 - ECdescuento3_1;
        Console.WriteLine($"Felicidades, se ha aplico un descuendo del 10% \nEl precio final es: {ECprecio_final3_1}");
    }
    else
    {
        Console.WriteLine($"El precio ingresado no aplica a descuento\nEl precio final es: {ECprecio_producto3_1}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO #4 - VALIDAR USUARIO Y CONTRASEÑA
Console.WriteLine("- - - VALIDAR USUARIO Y CONTRASEÑA - - - \n");
string ECUsarioCorrecto4_1 = "raquel", ECContraCorrecta4_1 = "123456", ECUsuario4_1, ECContrasena4_1;
try
{
    Console.WriteLine("Ingrese su usuario: ");
    ECUsuario4_1 = Console.ReadLine()!;

    Console.WriteLine("\nIngrese su contraseña: \n");
    ECContrasena4_1 = Console.ReadLine()!;

    if (ECUsuario4_1 == ECUsarioCorrecto4_1 && ECContrasena4_1 == ECContraCorrecta4_1)
    {
        Console.WriteLine("\nCONTRASEÑA CORRECTA\nBIENVENIDA\n");
    }
    else
    {
        Console.WriteLine("\nUSUARIO O CONTRASEÑA INCORRECTA\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 5 - DETERMINAR SI UN NUMERO ES PAR O IMPAR
Console.WriteLine("- - - DETERMINAR SI UN NUMERO ES PAR O IMPAR - - - \n");
int ECnumero5_1;
try
{
    Console.WriteLine("Ingrese un numero: ");
    ECnumero5_1 = Convert.ToInt32(Console.ReadLine()!);

    if (ECnumero5_1 % 2 == 0)
    {
        Console.WriteLine($"El número ingresado: {ECnumero5_1} es Par.\n");
    }
    else
    {
        Console.WriteLine($"El número ingresado:  {ECnumero5_1} es Impar.\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 6 - MOSTRAR UN MENSAJE DE APROBACION O RECHAZO DE PRESTAMO
Console.WriteLine("- - - MOSTRAR UN MENSAJE DE APROBACION O RECHAZO DE PRESTAMO - - - \n");
double ECPrestamo6_1;
int ECedad6_1;
try
{
    Console.WriteLine("Ingrese el monto que deseas de prestamo: ");
    ECPrestamo6_1 = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("Ingresa tu edad");
    ECedad6_1 = Convert.ToInt32(Console.ReadLine()!);

    if (ECedad6_1 > 60 || ECPrestamo6_1 < 5000)
    {
        Console.WriteLine($"Prestamo de: ${ECPrestamo6_1} aprobado");
    }
    else
    {
        Console.WriteLine($"Prestamo de: ${ECPrestamo6_1} no aprobado");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 7 - CALCULAR EL AREA DE UNA FIGURA GEOMETRICA
Console.WriteLine("- - - CALCULAR EL AREA DE UNA FIGURA GEOMETRICA - - - \n");
string ECTipoFigura7_1;
double ECresultado7_1, ECbasetriangulo7_1, ECalturatriangulo7_1, ECbasecuadrado7_1, ECradiocirculo7_1;
double ECresultado7_2, ECresultado7_3, ECPi7_1;
Console.WriteLine("Escriba la figura que desee operar: (triangulo, cuadrado o circulo): ");
ECTipoFigura7_1 = Console.ReadLine()!.ToLower();
try
{
    if (ECTipoFigura7_1 == "triangulo")
    {
        Console.WriteLine("\nUsted escribio triangulo\nPor favor Ingrese la base: ");
        ECbasetriangulo7_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nIngrese la altura: ");
        ECalturatriangulo7_1 = Convert.ToDouble(Console.ReadLine());

        ECresultado7_1 = (ECbasetriangulo7_1 * ECalturatriangulo7_1) / 2;

        Console.WriteLine($"El area del triangulo es: {ECresultado7_1}\n");
    }

    else if (ECTipoFigura7_1 == "cuadrado")
    {
        Console.WriteLine("\nUsted ingreso cuadrado\nPorfavor Ingrese la base: ");
        ECbasecuadrado7_1 = Convert.ToDouble(Console.ReadLine());
        ECresultado7_2 = (ECbasecuadrado7_1 * ECbasecuadrado7_1);
        Console.WriteLine($"\nEl area del cuadrado es: {ECresultado7_2}\n");
    }

    else if (ECTipoFigura7_1 == "circulo")
    {
        Console.WriteLine("\nUsted escribio circulo\nPorfavor Ingrese el radio");
        ECradiocirculo7_1 = Convert.ToDouble(Console.ReadLine());
        ECPi7_1 = 3.1416;

        ECresultado7_3 = (ECPi7_1 * (ECradiocirculo7_1 * ECradiocirculo7_1));

        Console.WriteLine($"El area del circulo es: {ECresultado7_3}\n");
    }
    else
    {
        Console.WriteLine("Error, debe escribir una de las opciones de figura geometrica");
    }

}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//PRACTICA DEL USO SWICH
//EJERCICIO 1 - CONVERTIR UN NUMERO DE LETRA A NUMERO
//Solicitar al usuario un número del 1 al 5 en letra ("uno", "dos", "tres", "cuatro", "cinco") y mostrar el número en dígito.
Console.WriteLine("- - - CONVERTIR UN NUMERO DE LETRA A NUMERO - - - \n");
int SWNumeroenNumero1_1;
string SWNumeroenLetras1_1;
try
{
    Console.WriteLine("Ingrese solo un número de letra segun esta opcion: (uno, dos, tres, cuatro, cinco): ");
    SWNumeroenLetras1_1 = Console.ReadLine()!.ToLower();
    switch (SWNumeroenLetras1_1)
    {
        case "uno":
            SWNumeroenNumero1_1 = 1;
            break;

        case "dos":
            SWNumeroenNumero1_1 = 2;
            break;

        case "tres":
            SWNumeroenNumero1_1 = 3;
            break;

        case "cuatro":
            SWNumeroenNumero1_1 = 4;
            break;

        case "cinco":
            SWNumeroenNumero1_1 = 5;
            break;

        default:
            Console.WriteLine("\nLo ingresado no es valido, intente de nuevo\n");
            return;
    }
    Console.WriteLine($"\nEl numero en letras ingresado a numero entero es: {SWNumeroenNumero1_1}");
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();


//EJERCICIO 2 - MOSTRAR EL DIA DE LA SEMANA A PARTIR DE UN NUMERO
Console.WriteLine("- - - MOSTRAR EL DIA DE LA SEMANA A PARTIR DE UN NUMERO - - - \n");
int SWnumeroDia2_1;
string SWdiaSemana2_1;

try
{
    Console.WriteLine("Ingrese un número del 1 al 7 para mostrar el día de la semana\n");
    SWnumeroDia2_1 = Convert.ToInt32(Console.ReadLine());
    SWdiaSemana2_1 = "";
    switch (SWnumeroDia2_1)
    {
        case 1:
            SWdiaSemana2_1 = "lunes";
            break;
        case 2:
            SWdiaSemana2_1 = "martes";
            break;
        case 3:
            SWdiaSemana2_1 = "miércoles";
            break;
        case 4:
            SWdiaSemana2_1 = "jueves";
            break;
        case 5:
            SWdiaSemana2_1 = "viernes";
            break;
        case 6:
            SWdiaSemana2_1 = "sábado";
            break;
        case 7:
            SWdiaSemana2_1 = "domingo";
            break;
        default:
            Console.WriteLine("Número de día ingresado no es valido");
            return;
    }

    Console.WriteLine($"El día de la semana es: {SWdiaSemana2_1}");
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 3 - CALCULAR EL IMPORTE A PAGAR POR UN SERVICIO
Console.WriteLine("- - - CALCULAR EL IMPORTE A PAGAR POR UN SERVICIO - - - \n");
string SWTipoServicio3_1;
double SWImpotePagar3_1;
try
{
    Console.WriteLine("Escriba el tipo de servicio por la opcion dada:\n(lavado de auto, cambio de aceite, revision mecanica):\n");
    SWTipoServicio3_1 = Console.ReadLine()!.ToLower();
    switch (SWTipoServicio3_1)
    {
        case "lavado de auto":
            SWImpotePagar3_1 = 35.00;
            break;
        case "cambio de aceite":
            SWImpotePagar3_1 = 45.00;
            break;
        case "revision mecanica":
            SWImpotePagar3_1 = 70.00;
            break;
        default:
            Console.WriteLine("Tipo de servicio escrito no es valido.");
            return;
    }
    Console.WriteLine($"\nEl importe total a pagar de: {SWTipoServicio3_1} es: Q{SWImpotePagar3_1}");
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 4 - MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS
Console.WriteLine("- - - MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS - - - \n");
string SWidioma4_1;
Console.WriteLine("Escriba el idioma de su preferencia dada las opciones: (español, ingles, frances):");
SWidioma4_1 = Console.ReadLine()!.ToLower();
try
{
    switch (SWidioma4_1)
    {
        case "español":
            Console.WriteLine("\n¡Bienvenido!");
            break;
        case "ingles":
            Console.WriteLine("\nWelcome!");
            break;
        case "frances":
            Console.WriteLine("\nBienvenue!");
            break;
        default:
            Console.WriteLine("\nEl idioma escrito no es valido.");
            return;
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();

//EJERCICIO 5 - EVALUAR LA CALIFICACION DE UN EXAMEN
Console.WriteLine("- - - EVALUAR LA CALIFICACION DE UN EXAMEN - - - \n");
double SWCalificacion5_1;
string SWmensaje5_1;
try
{
    Console.WriteLine("Ingrese la calificacion del examen: \n");
    SWCalificacion5_1 = Convert.ToDouble(Console.ReadLine()!);

    if (SWCalificacion5_1 < 0 || SWCalificacion5_1 > 100)
    {
        Console.WriteLine("No valido, la calificacion debe ser un numero del 0 a 100\n");
    }
    else if (SWCalificacion5_1 % 1 != 0)
    {
        Console.WriteLine("No valido, La calificación debe ser un número entero\n");
    }
    switch (SWCalificacion5_1)
    {
        case 100:
            SWmensaje5_1 = "Perfecta, ¡Felicidades";
            break;
        case >= 90 and <= 99:
            SWmensaje5_1 = "Sobresaliente";
            break;
        case >= 80 and <= 89:
            SWmensaje5_1 = "Notable";
            break;
        case >= 71 and <= 79:
            SWmensaje5_1 = "Aprobatoria";
            break;
        case 70:
            SWmensaje5_1 = "Aprobatoria con la nota mínima";
            break;
        case >= 60 and <= 69:
            SWmensaje5_1 = "No aprobatoria";
            break;
        case >= 0 and <= 59:
            SWmensaje5_1 = "No aprobatoria, nota demasiado baja";
            break;
        default:
            Console.WriteLine("\nLa nota no es valida");
            return;
    }
    Console.WriteLine($"\nTu desempeño en el examen es: {SWmensaje5_1}");
}
catch (Exception ex)
{
    Console.WriteLine("\nHa ocurrido un error, intente de nuevo\n" + ex.Message);
}
Console.WriteLine("\n***Haga click a Enter"); Console.ReadLine();
