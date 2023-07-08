//////////////////////////////////////////////////////////////////////////////////////////////////
#include <Servo.h>
String g_code = "";
bool dataComplete = false;
Servo pen;
int hiz        =1;
int poz        =70;
int step_size  =0;
#define x_step       2 
#define y_step       3
#define x_dir        5
#define y_dir        6
/////////////////////////////////////////////////////////////////////////////////////////////////
void setup() 
{
  Serial.begin(9600);

  pinMode(13, OUTPUT);
  pen.attach(11);
  pen.write(poz);
  pinMode(x_step,        OUTPUT);
  pinMode(y_step,        OUTPUT);
  pinMode(x_dir,         OUTPUT);
  pinMode(y_dir,         OUTPUT);
 
  
}
//////////////////////////////////////////////////////////////////////////////////////////////////
void loop() 
   {
   serialEvent();
  
   if (dataComplete) 
     {
     dataComplete = false;
         if (g_code.substring( 0 , 1) == "Y")
           { step_size = (g_code.substring( 1 , 6).toInt()); 
            delay(10);
           if (g_code.substring( 6 , g_code.length() ) == "F")
             { delay(10);
             digitalWrite(y_dir, HIGH);
             for(int i=0; i<=step_size; i++)
               {
               y_onemm();
               }
             } 
           if (g_code.substring( 6 , g_code.length() ) == "R")
             { delay(10);
             digitalWrite(y_dir, LOW);
             for(int i=0; i<=step_size; i++)
               {
               y_onemm();
               }
             }
         } 
         if (g_code.substring( 0 , 1) == "X")
             {   step_size = (g_code.substring( 1 , 6).toInt()); 
             delay(10);
             if (g_code.substring( 6 , g_code.length() ) == "L")
               { delay(10);
               digitalWrite(x_dir, HIGH);
               for(int i=0; i<=step_size; i++)
                 {
                 x_onemm();
                 }
               }
             if (g_code.substring( 6 , g_code.length() ) == "R")
               { delay(10);
               digitalWrite(x_dir, LOW);
               for(int i=0; i<=step_size; i++)
                 {
                 x_onemm();
                 }
               }
             }
     if(g_code.substring( 2 , g_code.length()) == "ZU")
       { poz =(g_code.substring( 0 , 2).toInt());
       pen.write(poz);
       }
     if(g_code.substring( 2 , g_code.length()) == "ZD")
       { poz = (g_code.substring( 0 , 2).toInt());
       pen.write(poz);
       }


       g_code = "";
     }
   }
//////////////////////////////////////////////////////////////////////////////////////////////////
void serialEvent() // Seri porttan gelen verileri yakalayan fonksiyondur.
{
  while (Serial.available()) 
   {
    char dataChar = (char) Serial.read();
    
    if (dataChar == '\n') // Boş karakter geldiğinde veri tamamlanır.
     {
      dataComplete = true;
      break;
     }
    g_code += dataChar;
   }
}

void x_onemm()
{
  for (int i = 0; i < 5;i++)
  {
    digitalWrite(x_step, HIGH);
    delay(hiz);
    digitalWrite(x_step, LOW);
    delay(hiz);
  }
}
void y_onemm()
{
  for (int i = 0; i < 10;i++)
  {
    digitalWrite(y_step, HIGH);
    delay(hiz);
    digitalWrite(y_step, LOW);
    delay(hiz);
  }
}



