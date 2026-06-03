using System;

class Program
{
    static void Main()
    {
        IControl c1 = ControlFactory.GetControl("button");
        c1.Draw();

        IControl c2 = ControlFactory.GetControl("textbox");
        c2.Draw();

        IControl c3 = ControlFactory.GetControl("checkbox");
        c3.Draw();
    }
}