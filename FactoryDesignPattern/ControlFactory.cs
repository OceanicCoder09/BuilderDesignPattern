class ControlFactory
{
    public static IControl GetControl(string type)
    {
        if (type == "button")
        {
            return new Button();
        }
        else if (type == "textbox")
        {
            return new TextBox();
        }
        else if (type == "checkbox")
        {
            return new CheckBox();
        }

        return null;
    }
}