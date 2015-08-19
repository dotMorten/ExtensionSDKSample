using System;
using System.Reflection;
using MyControlsSDK.Design.Common;
using Microsoft.Windows.Design.Metadata;

[assembly: ProvideMetadata(typeof(MyControlsSDK.Design.MetadataRegistration))]

namespace MyControlsSDK.Design
{
	public class MetadataRegistration : MetadataRegistrationBase, IProvideAttributeTable
	{
		//private static AttributeTable _customAttributes;
		//private static bool _initialized;

		public MetadataRegistration() : base()
		{
			// Note:
			// The default constructor sets value of AssemblyFullName and 
			// XmlResourceName used by MetadataRegistrationBase.AddDescriptions().
			// The convention here is that the <RootNamespace> in .design.csproj
			// (or Default namespace in Project -> Properties -> Application tab)
			// must be the same as runtime assembly's main namespace (t.Namespace)
			// plus .Design.
			Type t = MyControlsSDK.Design.Types.SdkTypes.MyCustomControlType;
			AssemblyName an = t.Assembly.GetName();
			AssemblyFullName = ", " + an.FullName;
			XmlResourceName = typeof(MetadataRegistration).Namespace + "." + an.Name + ".XML";
		}

		#region IProvideAttributeTable Members

		/// <summary>
		/// Gets the AttributeTable for design time metadata.
		/// </summary>
		public AttributeTable AttributeTable
		{
			get
			{
				return BuildAttributeTable();
			}
		}

		#endregion
	}
}