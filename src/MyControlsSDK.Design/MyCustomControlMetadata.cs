using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.PropertyEditing;

namespace MyControlsSDK.Design
{
	internal class MyCustomControlMetadata : AttributeTableBuilder
	{
		public MyCustomControlMetadata()
			: base()
		{

			AddCallback(MyControlsSDK.Design.Types.SdkTypes.MyCustomControlType,
				b =>
				{
					b.AddCustomAttributes("SomeValue", new CategoryAttribute("My Custom Properties"));
				}
			);
		}
	}
}
