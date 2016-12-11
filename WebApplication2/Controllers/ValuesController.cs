using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Xama.Portable;

namespace WebApplication2.Controllers {

	public class ValuesController : ApiController {
		// GET api/values
		public List<TaskItem> Tasks { get; set; }

		public IEnumerable<User> Get() {
			
				var baza = new UserDBCtxt();
			
			return baza.Users.ToList();
		}

		

		// GET api/values/5
		public string Get(int id) {
			return "value";
		}

		// POST api/values
		public void Post([FromBody] string value) {
		}

		// PUT api/values/5
		public void Put(int id, [FromBody] string value) {
		}

		// DELETE api/values/5
		public void Delete(int id) {
		}
	}

}
