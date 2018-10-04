using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class XL_CHUONGTRINH : XL_BANG
	{
		public XL_CHUONGTRINH() : base("SINHVIEN") { }
		public XL_CHUONGTRINH(string chuoiSQL) : base("SINHVIEN", chuoiSQL) { }
	}
}
