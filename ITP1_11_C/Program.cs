using System;
using System.Linq;
using System.Collections.Generic;

class Dice
{
    private int[] surfaces = { 0, 1, 2, 3, 4, 5, 6 };

    public Dice(int[] surfaces)
    {
        this.surfaces = surfaces;
    }

    public void up()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[2];
        surfaces[2] = surfaces[6];
        surfaces[6] = surfaces[5];
        surfaces[5] = surfaces[0];
    }

    public void down()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[5];
        surfaces[5] = surfaces[6];
        surfaces[6] = surfaces[2];
        surfaces[2] = surfaces[0];
    }

    public void left()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[3];
        surfaces[3] = surfaces[6];
        surfaces[6] = surfaces[4];
        surfaces[4] = surfaces[0];
    }

    public void right()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[4];
        surfaces[4] = surfaces[6];
        surfaces[6] = surfaces[3];
        surfaces[3] = surfaces[0];
    }

    public void rrotate()
    {
        surfaces[0] = surfaces[2];

        surfaces[2] = surfaces[4];
        surfaces[4] = surfaces[5];
        surfaces[5] = surfaces[3];
        surfaces[3] = surfaces[0];
    }

    public void lrotate()
    {
        surfaces[0] = surfaces[2];

        surfaces[2] = surfaces[3];
        surfaces[3] = surfaces[5];
        surfaces[5] = surfaces[4];
        surfaces[4] = surfaces[0];
    }

    public int getNum(int num)
    {
        return surfaces[num];
    }
}

class Program
{
    static void Main()
    {
        string[] Input1 = Console.ReadLine().Split(' ');
        string[] Input2 = Console.ReadLine().Split(' ');
        int[] iInput1 = new int[7];
        int[] iInput2 = new int[7];
        iInput1[0] = 0;
        iInput2[0] = 0;
        for (int i = 0; i < Input1.Length; i++)
        {
            iInput1[i + 1] = int.Parse(Input1[i]);
            iInput2[i + 1] = int.Parse(Input2[i]);
        }
        Dice dice1 = new Dice(iInput1);
        Dice dice2 = new Dice(iInput2);

        for(int i = 1; i < 7; i++)
        {
            switch(i)
            {
                case 1:
                    break;
                case 2:
                    dice1.up();
                    break;
                case 3:
                    dice1.left();
                    break;
                case 4:
                    dice1.up();
                    dice1.up();
                    break;
                case 5:
                    dice1.left();
                    break;
                case 6:
                    dice1.down();
                    break;

            }
            for(int j = 0; j < 4; j++)
            {
                dice1.rrotate();
                if (dice2.getNum(2) == dice1.getNum(2))
                {
                    if (dice2.getNum(3) == dice1.getNum(3))
                    {
                        if (dice2.getNum(5) == dice1.getNum(5))
                        {
                            if (dice2.getNum(4) == dice1.getNum(4))
                            {
                                if(dice2.getNum(6) == dice1.getNum(6))
                                {
                                    Console.WriteLine("Yes");
                                    goto readend;
                                }
                                
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("No");
    readend:;
    }
}