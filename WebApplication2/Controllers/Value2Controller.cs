using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Xama.Portable;

namespace WebApplication2.Controllers {

	public class Value2Controller : ApiController {
		// GET api/value2
		

		public IEnumerable<TaskItem> Get() {
			var baza = new TaskDBCtxt();
			return baza.TaskItems.ToList();

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
