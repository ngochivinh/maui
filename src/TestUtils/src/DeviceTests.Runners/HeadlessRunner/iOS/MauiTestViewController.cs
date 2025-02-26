﻿#nullable enable
using Microsoft.Extensions.DependencyInjection;
using UIKit;

namespace Microsoft.Maui.TestUtils.DeviceTests.Runners.HeadlessRunner
{
	public class MauiTestViewController : UIViewController
	{
		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();

			var runner = MauiTestApplicationDelegate.Current.Services.GetRequiredService<HeadlessTestRunner>();

			await runner.RunTestsAsync();
		}
	}
}