using System.Collections.Generic;

namespace Pagination.Models
{
	public class IndexViewModel
	{
		public IEnumerable<Phone> Phones { get; set; }
		public PageInfo PageInfo { get; set; }
	}
}