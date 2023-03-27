namespace USSDApi;
public class prompts
{
    public string text { get; set; }
    public string param { get; set; }
    public pType pType { get; set; }

    public prompts()
    {

    }

    public prompts(string txt, string prm, pType pt)
    {

        this.text = txt;
        this.param = prm;
        this.pType = pt;


    }

}



