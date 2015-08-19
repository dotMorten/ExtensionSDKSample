# ExtensionSDKSample
Sample project showing how to create an Extension SDK from a Windows Universal Control Llibrary


Projects:
- `MyControlsSDK` : Managed Control library SDK, which has custom controls, images, generic.xaml template etc.
- `MyControlsNative` : Native library that MyControlsSDK takes a dependency on.
- `MyControlsSDK.Design` : Provides design-time extra data for the controls in MyControlsSDK
- `VSIX` : Creates an ExtensionSDK VSIX installer so you can install the SDK into Visual Studio
- `TestApp.ProjectReference` : Test app that tests the SDK by referencing the SDK as a project reference
- `TestApp.SDKReference` : Test app that tests the SDK by referencing the SDK using an at-build-time-generated ExtensionSDK (similar to how users will be using your SDK when installed from the VSIX)
