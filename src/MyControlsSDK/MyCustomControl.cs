using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace MyControlsSDK
{
	/// <summary>
	/// Custom control
	/// </summary>
	public sealed class MyCustomControl : Control
	{
		/// <summary>
		/// Instantiates an instance of <see cref="MyCustomControl"/>
		/// </summary>
		public MyCustomControl()
		{
			this.DefaultStyleKey = typeof(MyCustomControl);

			//Ensure the native bits are deployed correctly
			MyControlsNative.Class1 instance = new MyControlsNative.Class1();
			var result = instance.Test();
			if (result != 1)
				throw new Exception("Something is wrong with the native resource");
        }


		/// <summary>
		/// Just some value
		/// </summary>
		public int SomeValue
		{
			get { return (int)GetValue(SomeValueProperty); }
			set { SetValue(SomeValueProperty, value); }
		}

		/// <summary>
		/// Identifies the <see cref="SomeValue"/> dependency property.
		/// </summary>
		public static readonly DependencyProperty SomeValueProperty =
			DependencyProperty.Register("SomeValue", typeof(int), typeof(MyCustomControl), new PropertyMetadata(0));  
	}
}
