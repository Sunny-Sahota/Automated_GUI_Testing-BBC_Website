using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWalkthrough
{
	public class AppConfigReader
	{
		public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
		public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["login_url"];
		public static readonly string HelpSignInPageUrl = ConfigurationManager.AppSettings["helpSignIn_url"];
		public static readonly string RegisterUrl = ConfigurationManager.AppSettings["register_url"];
	}
}
