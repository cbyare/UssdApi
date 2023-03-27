
namespace USSDApi;
public class pType
{
    public string name { get; set; }
    public int min { get; set; }
    public int max { get; set; }
    public bool isNum { get; set; }

    public pType()
    {


    }

    public pType(string nm, int min, int max, bool isnum)
    {
        this.name = nm;
        this.min = min;
        this.max = max;
        this.isNum = isnum;

    }

    public pType(string name)
    {
        this.name = name;

    }

}


