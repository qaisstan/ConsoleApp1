// See https://aka.ms/new-console-template for more information


//********************************* ARRAY *************************************************************
/*
int[] luckyNumber = { 4, 8 ,15, 16, 23, 42 };
luckyNumber[1] = 50;
Console.WriteLine( luckyNumber);
Console.ReadLine();


string[] friends = new string[10];
friends[0] = "jim";
friends[1] = "kelly";
*//*****************************************************************


//********************************METHOD***************************************************************** 
/*
SayHi(" QAIS", 33);
SayHi(" john", 56);
SayHi(" tom", 32);

static void SayHi(string name, int age)
{
 Console.WriteLine("Hello " + name + " and you are "+age+" years old.");
}
*/

//**************************** RETURN METHOD ***************************************************************** 
/*
int cubedNumber = cube(5);
Console.WriteLine(cubedNumber);

static int cube(int num)
{
    int result = num * num * num;
    return result;
}
*/

//**************************** IF STATEMENTS *****************************************************************  
/*
bool isMale = true;
bool isTall = true;

if (isMale && isTall)
{ Console.WriteLine("you are a tall male!");} 
else if (isMale && !isTall)
{ Console.WriteLine("You are a short male");}
else if (!isMale && isTall)
{ Console.WriteLine( " you are not male and but you are tall");}
else
{ Console.WriteLine("you are not male neither tall!");}
*/

//****************************** comparisions *****************************************************************  
/*
Console.WriteLine(getMax(10,20, 30));


static int getMax(int num1, int num2, int num3)
{

    int result;
    if (num1 >= num2 && num1 >= num3)
    {
        result = num1;
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        result = num2;
    }
    else
    {
        result = num3;
    }

    return result;
}       
*/

//**************** BUILDING A CALCULATOR WITH IF STATEMENT!***************************************************************** 
/*
Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write(" Enter operator: ");
string op = Console.ReadLine();


Console.Write("Enter a number: ");                  
double num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+")
{
     Console.Write(num1 + num2);
}   else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}   else if (op == "*")
{
   Console.Write(num1 * num2);
}
else if (op == "/")
{
   Console.Write( num1 / num2);
}
else
{
    Console.WriteLine("Invalid Operator!");
}
*/

//***************************** SWITCH STATEMENT! ******************************************************************** 
/*
Console.WriteLine(getDay(6));

static string getDay(int dayNum)
{
    string dayName;


    switch (dayNum)
    {
        case 0:
            dayName = "sunday";
            break;
        case 1:
            dayName = "monday";
            break;
             
        case 2:
            dayName = "tuesday";
            break;
        
        case 3:                 
            dayName = "wednesday";
            break;              
        
        case 4:                 
            dayName = "thursday";
            break;              
        
        case 5:                 
            dayName = "friday";
            break; 
        
        case 6:                 
            dayName = "saturday";
            break; 
        
        default:
            dayName = "invalid day number!";
            break;
    }
    
    return dayName; 
}
*/

//**************************** WHILE LOOPS ***************************************
/*
int index = 1;
while (index <= 5)
{
    Console.WriteLine(index);
    index++;
}
*/

//********************** BUILDING A GUSSING GAME *************************************
/*
string secretWord = "giraffe";
string guess = "";
int gussedCount = 0;
int guesslimit = 3;
bool outOfGusses = false;

while (guess != secretWord && !outOfGusses)
{
    if (gussedCount < guesslimit )
    {
        Console.WriteLine("Enter guess: ");
        guess = Console.ReadLine();
        gussedCount++;
    }
    else
    {
        outOfGusses = true;
    }
}
if (outOfGusses)
{
    Console.WriteLine("you lose!");
}
else
{
    Console.WriteLine("You win! ");
}
*/

//***************************** FOR LOOPS **********************************************
/*
int[] luckNumbers = { 4, 8, 34, 54, 23, 23 };
for (int i = 0; i < luckNumbers.Length; i++)
{
    Console.WriteLine(luckNumbers[i]);
}

*/

//************************** BUILDING AN EXPONENT METHOD *******************************
/*
Console.WriteLine(GetPow(3, 4));

static int GetPow(int basNum, int powNum)
{
    int result = 1;

    for (int i = 0; i < powNum; i++)
    {
        result = result * basNum;
    }
    return result;
}

*/
    
//************************* 2D ARRAY *********************************************
/*
int[,] numberGrid =
{

    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};
Console.WriteLine(numberGrid[1,1]);
*/

//********************* CLASSES & OBJECTS ****************************************
/*
using ConsoleApp1;

book book1 = new book();
book1.title = "Harry Potter";
book1.author = "JK Rowling";
book1.pages = 400;

book book2 = new book();
book2.title = "lords of the rings";
book2.author = "qais";
book2.pages = 500;


Console.WriteLine(book2.author);

*/

//********************** CONSTRUCTORS *******************************
/*
using ConsoleApp1;

book book1 = new book("Harry Potter", "JK Rowling", 400);


book book2 = new book("lords of the rings", "qais", 500 );

Console.WriteLine(book2.title);
*/

//************************ OBJECT METHOD *******************************
/*
using ConsoleApp1;

Student student1 = new Student("jim", "business", 2.8);
Student student2 = new Student("Pam", "art", 3.6);

Console.WriteLine(student1.hasHonorss());
Console.WriteLine(student2.hasHonorss());
*/

//******************** STATIC CLASS ATTRIBUTES *****************************
/*
using ConsoleApp1;

Song holiday = new Song("holiday", "Green Day", 200);
Console.WriteLine(Song.songCount);
Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
Console.WriteLine(kashmir.getSongCount());
*/

//******************* STATIC METHODS & CLASSES *******************************
/*
using ConsoleApp1;

useFulTools.SayHi("qais");
*/

//************************** INHERITANCE ***************************************
/*
using ConsoleApp1;

Chef Chef = new Chef();
Chef.MakeChicken();

ItalianChef italianChef = new ItalianChef();
italianChef.MakePasta;
*/

//**************************** STRINGS ******************************************

/*
using System.Globalization;

string textString = " this sdl fjsL JLJ LKJ LKJ KLJLKJ LKJLKJlkjlk";
TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
TextInfo englishTextInfo = new CultureInfo("en-us", false).TextInfo;
Console.WriteLine(textString.ToLower());
*/
/*
using System.Globalization;

string TextString = "Qais";
for (int i = 0; i < TextString.Length; i++)
{
    Console.WriteLine(TextString[i]);
}
*/





















/*
Skriv ett program som frågar användaren efter ett lösenord. 
Hitta på ett hemligt lösenord och spara det i en variabel. 
När användaren har skrivit in ett lösenord ska programmet jämföra med det 
sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

*/
/*
Console.WriteLine(" Please type your Name: ");
string userName = Console.ReadLine();
Console.WriteLine(" Please type your Password: ");
string password = Console.ReadLine();
string realPassword = "1234";
 k

if (password == realPassword && userName == userName)
{
    Console.WriteLine("You are logged in! ");
}
else
{
    Console.WriteLine("You have entered either wrong password or username");
}
*/

/* Skriv ett program som frågar användaren efter ett tal.
 Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.*/

/*
Console.WriteLine("Skriv Ett tal: ");
int tal = Convert.ToInt32(Console.ReadLine());

if (tal < 100)
{
    Console.WriteLine("Talet är mindre än 100 ");
}
else {
    Console.WriteLine(" Talet är större eller lika med hundra! ");
}
*/

/* Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal.
 Skriv hälsningen så många gånger som användaren anger.*/
/*
Console.WriteLine("Ange ett tal:");
string num = Console.ReadLine();
int numAsInt = int.Parse(num);

if (numAsInt < 100)
{
    Console.WriteLine("Talet är mindre än 100");
}
else if (numAsInt == 100)
{
    Console.WriteLine("Talet är lika med 100");

}
else if (numAsInt > 100)
{
    Console.WriteLine("Talet är större än 100");
}
*/

/*Skriv ett program som upprepade gånger frågar användaren efter ett
 tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). 
 Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. 
 Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

Console.WriteLine("skriv ett tal: ");
int förstaTal = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv Operator: ");
string tecken = Console.ReadLine();

Console.WriteLine(" Skriv ett Tal");
int andraTal = int.Parse(Console.ReadLine());



if (tecken == "+")
{
    int sum = andraTal + förstaTal;
    Console.WriteLine( "talet blir  "  + sum + " .");
}
else
{
    Console.WriteLine("talet eller tecknet är fel! ");
}
*/


/*Skriv ett program som ber användaren skriva in en månad.
 Programmet ska göra om månaden till månadens siffervärde. 
 T.ex. ska januari bli 1 och december 12. Använd switch. 
 Alternativ: Prova även att lösa uppgiften med array och/eller enum.
 
 Extra utmaning: Be användaren om två månader och räkna sedan ut hur många månader som skiljer mellan dem.
  Tänk på att ett månaderna upprepas till nästa år. Skriver man mars och maj bör man få 2. Likaså om man skriver november och januari.*/
/*

string månad = (Console.ReadLine());
switch (månad)
{
    case "jan":
        Console.WriteLine("1");
        break;
    case "feb":
        Console.WriteLine("2");
        break;
    case "mar":
        Console.WriteLine("3");
        break;
    case "apr":
        Console.WriteLine("4");
        break;
    case "maj":
        Console.WriteLine("5");
        break;
    case "jun":
        Console.WriteLine("6");
        break;
    case "jul":
        Console.WriteLine("7");
        break;
    case "aug":
        Console.WriteLine("8");
        break;
    case "sep":
        Console.WriteLine("9");
        break;
    case "okt":
        Console.WriteLine("10");
        break;
    case "nov":
        Console.WriteLine("11");
        break;
    case "dec":
        Console.WriteLine("12");
        break;
    default: Console.WriteLine("Du har skrivit fel månad! ");
        break;
}
*/

/* Skapa ett program som skriver ut 1 på första raden, 2 på nästa,
 sedan 4, o.s.v (dubbelt så hög siffra för varje rad). Fortsätt till du skrivit ut 16 rader.*/

/*

int num1 = 1;

for (num1 = 1; num1 < 100000; num1= num1 * 2)
{
    if (num1 <= Math.Pow(2,16)-1)
    {
        Console.WriteLine(num1);
    }
    
}

int outnumber = 1;

for (int i = 0; i < 16; i++)
{
    Console.WriteLine(outnumber);
    outnumber *= 2;
}
*/



/*
Skriv ett program som frågar användaren efter ett tal mellan 1 och 100. 
Programmet ska ha ett hemligt tal lagrat i en variabel. 
Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet. 
Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det. 
Exempel: programmet har det hemliga talet 27. Användaren gissar på 50. 
Programmet skriver ut att användaren gissade för högt. Användaren gissar på 20. Programmet skriver ut att det var för lågt. 
Användaren gissar på 27. Programmet skriver ut att det var rätt och avslutas.

Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på google hur det fungerar). 
Spara antalet gissningar i en variabel och skriv ut det när användaren gissat rätt.

Extra utmaning 2: skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”. 
Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången. 
Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). 
Skriv även ut poäng. 
*/
/*
int secretNum = 7;
int Num = 0;
Console.WriteLine("Skriv ett tal mellan 1 till 10: ");
Num = int.Parse(Console.ReadLine());

{
    
}
if (Num == secretNum)
{
    Console.WriteLine("YOU HAVE GUSSED IT RIGHT!!!");
    
}

else if (Num < secretNum)
{
    Console.WriteLine(" number is smaller than " + Num);
    int numText = int.Parse(Console.ReadLine());
    
} else if(Num > secretNum)
{
    Console.WriteLine("The number is bigger then " + Num);
    Num = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("try again");
}

   
// Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j */
/*
string  greetings = Console.ReadLine();
 
for (int i = 0; i < greetings.Length; i++)
{
    Console.WriteLine(greetings.ToUpper()[i]);
}
*/



/* 11 Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
 Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.

Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.
*/

/*
string[] siffror = new string[10]{ "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åta", "nio" };


for (int i = 0; i < 10; i++)
{
}
Console.WriteLine(siffror[1]);
*/




/* 12  Fråga användaren hur många tal den vill mata in. 
Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv). När alla tal är inmatade skriv ut dem i omvänd ordning.
*/












// 13 Be användaren mata in en text. Skriv sedan ut texten baklänges.   varför kom den här using microsoft ?? ********************************

/*
using Microsoft.VisualBasic;

Console.WriteLine("Mata in ett text: ");

string input = Console.ReadLine();
Console.WriteLine(Strings.StrReverse(input));
*/




/* Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

Extra utmaning: Skriv ut texten översatt till rövarspråket.*/

using System.Linq.Expressions;
using System.Threading.Channels;
using Microsoft.VisualBasic;






// 15 Ett palindrom är ett ord som blir samma framlänges som baklänges.
// Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte. *****************************************

/*

Console.WriteLine("Skriv in ett ord! ");
string pal = Console.ReadLine();

Console.WriteLine(Strings.StrReverse(pal));
string lap = pal;

while (pal == lap)
{
    return true;
}

*/






//  Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra talet).
// Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.

/*
int results = 0;
Console.WriteLine("mata in ditt tal: ");
int num1 = Convert.ToInt32(Console.Read());
char op = Convert.ToChar(Console.Read());
int num2 = Convert.ToInt32(Console.Read());
int sum = 0;
/*
 
/*
if (op = "+")
{
    Console.WriteLine(num1 * num2);
}


*/


/*
switch (op)
{
    case '+':
        results = num1 + num2;
        Console.WriteLine(results);
        break;
    case '-':
        results = num1 - num2;
        Console.WriteLine(results);
    case '/':
        results = num1 / num2;
        Console.WriteLine(results);
    case '*':
        results = num1 * num2;
        Console.WriteLine(results);
}

*/



// Gör ett program som ber användaren mata in en text.
// Be sedan användaren mata in en sträng som är en del av den första texten.
// Skriv ut hela texten med den del man angav markerad i en annan färg.
// Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”.
// Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz






