
/*
 * 
 * some methods overloading
 * 
 * 
 */

Dom element = new Dom();

element.render();
element.render(new header());
element.render(new body());
element.render(new footer());



public class Dom()
{
    public void render()
    {
        Console.WriteLine("Render Started: ");
    }

    public void render(header head)
    {
        Console.WriteLine("<head></head>");
    }

    public void render(body body)
    {
        Console.WriteLine("<body></body>");
    }

    public void render(footer footer)
    {
        Console.WriteLine("<footer></footer>");
    }


}

public class header()
{

}

public class body()
{

}

public class footer()
{

}

