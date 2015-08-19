# ExtensionSDKSample
Sample project showing how to create an Extension SDK from a Windows Universal Control Llibrary


Projects:
- `MyControlsSDK` : Managed Control library SDK, which has custom controls, images, generic.xaml template etc.
- `MyControlsNative` : Native library that MyControlsSDK takes a dependency on.
- `MyControlsSDK.Design` : Provides design-time extra data for the controls in MyControlsSDK
- `VSIX` : Creates an ExtensionSDK VSIX installer so you can install the SDK into Visual Studio
- `TestApp.ProjectReference` : Test app that tests the SDK by referencing the SDK as a project reference
- `TestApp.SDKReference` : Test app that tests the SDK by referencing the SDK using an at-build-time-generated ExtensionSDK (similar to how users will be using your SDK when installed from the VSIX)


## Notes
MyControlsSDK and MyControlsNative performs a post-build step that copies the generated files into a temporary ExtensionSDK layout. This is useful for testing the SDK, and is used by `TestApp.SDKReference`

To build the `VSIX` project, make sure you have built the release build for x86, x64 and ARM for the two SDK projects and the .design project (x86) first.

Also: The VSIX specifies the Target Platform Identifier as `Windows`, where the correct for Universal apps SDKs are `Windows Kits`. However due to a VS bug, this TPI isn't available and if you try and manually enter it, the build will fail. Instead you must unzip the generated VSIX, manually edit it, and zip it up again.

## Generated ExtensionSDK Layout
```
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\SDKManifest.xml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\WinUWPSDK_200x200.png
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\WinUWPSDK_32x32.png
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\DesignTime\CommonConfiguration\x86\MyControlsSDK.Design.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\DesignTime\CommonConfiguration\neutral\MyControlsSDK\Themes\Generic.xaml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsNative.pri
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK.pri
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK\MyControlsSDK.xr.xml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK\Assets\Logo.scale-100.png
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK\Assets\Logo.scale-150.png
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK\Properties\MyControlsSDK.rd.xml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\neutral\MyControlsSDK\Themes\Generic.xbf
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\x64\MyControlsNative.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\x86\MyControlsNative.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\Redist\CommonConfiguration\ARM\MyControlsNative.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\neutral\MyControlsNative.winmd
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\ARM\MyControlsSDK.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\ARM\MyControlsSDK.xml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\x64\MyControlsSDK.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\x64\MyControlsSDK.xml
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\x86\MyControlsSDK.dll
\Windows Kits\10\ExtensionSDKs\MyControlSDK\1.0.0\References\CommonConfiguration\x86\MyControlsSDK.xml
```
