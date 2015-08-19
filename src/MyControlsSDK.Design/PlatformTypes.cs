﻿using System;
using Microsoft.Windows.Design.Metadata;
#if NETFX_CORE
using Windows.UI.Xaml;
#else
using System.Windows;
#endif
namespace MyControlsSDK.Design.Types
{
	public class PlatformTypes
	{
		public static readonly Type DependencyObjectType = typeof(DependencyObject);

		public static readonly Type EditorBrowsableAttributeType = typeof(System.ComponentModel.EditorBrowsableAttribute);

		/// <summary>
		/// Used by MetadataRegistrationBase to get the browsable state
		/// </summary>
		/// <param name="editorBrowsableAttribute">This parameter must be of type 'System.ComponentModel.EditorBrowsableAttribute'</param>
		/// <returns></returns>
		public static bool IsBrowsable(object editorBrowsableAttribute)
		{
			if (editorBrowsableAttribute is System.ComponentModel.EditorBrowsableAttribute)
				return (editorBrowsableAttribute as System.ComponentModel.EditorBrowsableAttribute).State !=
					 System.ComponentModel.EditorBrowsableState.Never;
			return true;
		}

		public static class Control
		{
			public static readonly TypeIdentifier TypeId = new TypeIdentifier("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "Control");
			public static readonly PropertyIdentifier BackgroundProperty = new PropertyIdentifier(TypeId, "Background");
			public static readonly PropertyIdentifier BorderBrushProperty = new PropertyIdentifier(TypeId, "BorderBrush");
			public static readonly PropertyIdentifier BorderThicknessProperty = new PropertyIdentifier(TypeId, "BorderThickness");
		}

		public static class FrameworkElement
		{
			public static readonly TypeIdentifier TypeId = new TypeIdentifier("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "FrameworkElement");
			public static readonly PropertyIdentifier MarginProperty = new PropertyIdentifier(TypeId, "Margin");
			public static readonly PropertyIdentifier HorizontalAlignmentProperty = new PropertyIdentifier(TypeId, "HorizontalAlignment");
			public static readonly PropertyIdentifier VerticalAlignmentProperty = new PropertyIdentifier(TypeId, "VerticalAlignment");
			public static readonly PropertyIdentifier HeightProperty = new PropertyIdentifier(TypeId, "Height");
			public static readonly PropertyIdentifier WidthProperty = new PropertyIdentifier(TypeId, "Width");
		}

		public static class TextBlock
		{
			public static readonly TypeIdentifier TypeId = new TypeIdentifier("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "TextBlock");
			public static readonly PropertyIdentifier TextProperty = new PropertyIdentifier(TypeId, "Text");
		}

		public static class ContentControl
		{
			public static readonly TypeIdentifier TypeId = new TypeIdentifier("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "ContentControl");
			public static readonly PropertyIdentifier ContentProperty = new PropertyIdentifier(TypeId, "Content");
		}

		public static class Panel
		{
			public static readonly TypeIdentifier TypeId = new TypeIdentifier("http://schemas.microsoft.com/winfx/2006/xaml/presentation", "Panel");
		}
	}
}
