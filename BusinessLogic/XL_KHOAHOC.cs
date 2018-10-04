using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class XL_KHOAHOC : XL_BANG
	{
		public XL_KHOAHOC() : base("SINHVIEN") { }
		public XL_KHOAHOC(string chuoiSQL) : base("SINHVIEN", chuoiSQL) { }
	}
}
