using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Upgrade
{
	public class RollingUpgradePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:46")]
		public void Line46()
		{
			// tag::1cd3b9d65576a9212eef898eb3105758[]
			var response0 = new SearchResponse<object>();
			// end::1cd3b9d65576a9212eef898eb3105758[]

			response0.MatchesExample(@"PUT _cluster/settings
			{
			  ""persistent"": {
			    ""cluster.routing.allocation.enable"": ""primaries""
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:47")]
		public void Line47()
		{
			// tag::f27c28ddbf4c266b5f42d14da837b8de[]
			var response0 = new SearchResponse<object>();
			// end::f27c28ddbf4c266b5f42d14da837b8de[]

			response0.MatchesExample(@"POST /_flush");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:82")]
		public void Line82()
		{
			// tag::a21a7bf052b41f5b996dc58f7b69770f[]
			var response0 = new SearchResponse<object>();
			// end::a21a7bf052b41f5b996dc58f7b69770f[]

			response0.MatchesExample(@"POST _ml/set_upgrade_mode?enabled=true");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:97")]
		public void Line97()
		{
			// tag::7e49705769c42895fb7b1e2ca028ff47[]
			var response0 = new SearchResponse<object>();
			// end::7e49705769c42895fb7b1e2ca028ff47[]

			response0.MatchesExample(@"GET _cat/nodes");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:110")]
		public void Line110()
		{
			// tag::45ef5156dbd2d3fd4fd22b8d99f7aad4[]
			var response0 = new SearchResponse<object>();
			// end::45ef5156dbd2d3fd4fd22b8d99f7aad4[]

			response0.MatchesExample(@"PUT _cluster/settings
			{
			  ""persistent"": {
			    ""cluster.routing.allocation.enable"": null
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:128")]
		public void Line128()
		{
			// tag::5c53944aec2ce3e55854e315f0482029[]
			var response0 = new SearchResponse<object>();
			// end::5c53944aec2ce3e55854e315f0482029[]

			response0.MatchesExample(@"GET _cat/health?v");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:158")]
		public void Line158()
		{
			// tag::6b74ff6df5d7583add837b34a6c80a43[]
			var response0 = new SearchResponse<object>();
			// end::6b74ff6df5d7583add837b34a6c80a43[]

			response0.MatchesExample(@"GET _cat/recovery");
		}

		[U]
		[Description("upgrade/rolling_upgrade.asciidoc:175")]
		public void Line175()
		{
			// tag::f8cc4b331a19ff4df8e4a490f906ee69[]
			var catResponse = client.Cat.Health(h => h.Verbose());
			// end::f8cc4b331a19ff4df8e4a490f906ee69[]

			catResponse.MatchesExample(@"GET /_cat/health?v");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:182")]
		public void Line182()
		{
			// tag::c4270d3851c76898fc8b112c6c597444[]
			var response0 = new SearchResponse<object>();
			// end::c4270d3851c76898fc8b112c6c597444[]

			response0.MatchesExample(@"GET /_cat/nodes?h=ip,name,version&v");
		}

		[U(Skip = "Example not implemented")]
		[Description("upgrade/rolling_upgrade.asciidoc:197")]
		public void Line197()
		{
			// tag::3c5d5a5c34a62724942329658c688f5e[]
			var response0 = new SearchResponse<object>();
			// end::3c5d5a5c34a62724942329658c688f5e[]

			response0.MatchesExample(@"POST _ml/set_upgrade_mode?enabled=false");
		}
	}
}
