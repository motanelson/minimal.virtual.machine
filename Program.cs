using System;
using System.Runtime.CompilerServices;

class virtualMachine
{
    static int[] registers = new int[256];
    static String[] Keywords = { "MOVE", "LOAD", "STORE", "PRINT", "RESET", "EXIT", "QUIT" ,"HELP"};
    static String[] cLine = { "" };
    public static void Resets()
    {
    
     for (int i = 0; i < registers.Length; i++)registers[i] = 0;
    
    }
    public static int getRegisters(int r) 
    {
        r = r & 0xff;
        return registers[r];
    
    
    
    }
    public static void setRegisters(int r,int a) 
    { 
         r = r & 0xff;
         registers[r] = a;
    
    }
    public static void prints() 
    {
        Console.WriteLine(getRegisters(0));
    
    
    }
    public static void moves(int r, int a) 
    {
       setRegisters(r,a);
        
    
    }
    public static void loads(int r1, int r2) 
    { 
        int rr=getRegisters(r2);
        setRegisters(r1,rr);
    
    
    
    
    }
    public static void stores(int r1)
    {
        int rr = getRegisters(r1);
        setRegisters(0, rr);




    }
    public static void gets()
    {
        cLine = Console.ReadLine().Split(" ");
    
    
    }
    public static void helps()
    {
        Console.WriteLine("256 registers acumulator registe 0\nmov moves a number into a registors\n move 1 100\nload copy a register other\n load 0 1\nstore copy a registor to acumulator\n store 1\nprint acumulator\nprint\nexit exits quit \nexit\nquit\nhelp\n");
    }
    public static void machineLoop()
    {
        String[] ss = {""};
        int i1=0;int i2=0; int i3=0;
        Resets();
        helps();
        while (true)
        {
            Console.Write(">");
            gets();
            ss = cLine;
            ss[0] = ss[0].Trim();
            ss[0]=ss[0].ToUpper();
            if (ss[0]!="") {
                if (ss[0] == Keywords[0]) 
                {
                    if (ss.Length > 2) 
                    {
                        try
                        {
                            i1 = int.Parse(ss[1]);
                            i2 = int.Parse(ss[2]);
                            moves(i1,i2);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    
                    }
                
                }
                if (ss[0] == Keywords[1])
                {
                    if (ss.Length > 2)
                    {
                        try
                        {
                            i1 = int.Parse(ss[1]);
                            i2 = int.Parse(ss[2]);
                            loads(i1, i2);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                    }

                }
                if (ss[0] == Keywords[2])
                {
                    if (ss.Length > 1)
                    {
                        try
                        {
                            i1 = int.Parse(ss[1]);
                            
                            stores(i1);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                    }

                }
                if (ss[0] == Keywords[3])
                {
                    if (ss.Length > 0)
                    {
                        try
                        {
                            

                            prints();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                    }

                }
                if (ss[0] == Keywords[4])
                {
                    if (ss.Length > 0)
                    {
                        try
                        {


                            Resets();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }

                    }

                }
                if (ss[0] == Keywords[5] || ss[0] == Keywords[6]) break;
                if (ss[0] == Keywords[7]) helps();

            }



        }
    
    
    }

}





class machines 
{

    public static void Main() 
    { 
    
        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.Clear();

        virtualMachine.machineLoop();
    
    
    
    }





}

