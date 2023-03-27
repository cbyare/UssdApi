namespace USSDApi;

public class Root
{
    public string text { get; set; }
    public string endpoint { get; set; }
    public List<prompts> prompts { get; set; }


    public Root(string txt, string endp, List<prompts> prt)
    {
        this.text = txt;
        this.endpoint = endp;
        this.prompts = prt;
    }

    public Root(string txt, string endp)
    {
        this.text = txt;
        this.endpoint = endp;

    }


}
