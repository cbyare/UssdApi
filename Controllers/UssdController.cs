
namespace USSDApi.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UssdController : ControllerBase
    {

        [HttpGet(Name = "getUssd")]
        public IEnumerable<Root> Get()
        {
            
            List<Root> root = new List<Root>();
            List<prompts> pr = new List<prompts>();
            List<prompts> pr1 = new List<prompts>();
            pr.Add(new prompts("Transfer Money", "accountToTranfer", new pType("input", 6, 5, false)));
            pr.Add(new prompts("Enter amount", "amount", new pType("input", 1, 6, false)));
            pr.Add(new prompts("Are you sure you want to send ${1} to {0}?\n1. Yes\n2. No", "confirm", new pType("confirm")));
            root.Add(new Root("Blance", "/blance", pr1));
            root.Add(new Root("Transfer funds", "/fund-transfer", pr));
            return root.ToArray();
        }
    }
}