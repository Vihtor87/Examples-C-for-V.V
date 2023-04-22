// Нахождение максиммума из 9ти чисел (СТИХИЙНО!)

int a1 = 22;
int b1 = 32;
int c1 = 11;
int a2 = 8;
int b2 = 440;
int c2 = 35;
int a3 = 46;
int b3 = 43;
int c3 = 69;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);