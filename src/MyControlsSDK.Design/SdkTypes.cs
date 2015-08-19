using System;
using System.Collections.Generic;

namespace MyControlsSDK.Design.Types
{
	public class SdkTypes
	{
		private static Type m_myCustomControlType;
		public static Type MyCustomControlType
		{
			get
			{
				if (m_myCustomControlType == null)
					m_myCustomControlType = typeof(MyControlsSDK.MyCustomControl);
				return m_myCustomControlType;
			}
		}		
	}
}
