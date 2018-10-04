using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class XL_MONHOC : XL_BANG
	{
		public XL_MONHOC() : base("SINHVIEN") { }
		public XL_MONHOC(string chuoiSQL) : base("SINHVIEN", chuoiSQL) { }
	}
}
