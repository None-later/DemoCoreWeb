﻿using System;
using Xunit;

namespace IntegrationTests
{
	public class SuperDemoFixture : Fonlow.Testing.DefaultHttpClient
	{
		public SuperDemoFixture()
		{
			Api = new DemoWebApi.Controllers.Client.SuperDemo(HttpClient, BaseUri);
		}

		public DemoWebApi.Controllers.Client.SuperDemo Api { get; private set; }
	}


	[Collection("ServiceLaunch")]
	public partial class SuperDemoApiIntegration : IClassFixture<SuperDemoFixture>
	{
		public SuperDemoApiIntegration(SuperDemoFixture fixture)
		{
			api = fixture.Api;
		}

		DemoWebApi.Controllers.Client.SuperDemo api;

	}
}
