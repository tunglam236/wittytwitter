#region Using directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Resources;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Witty")]
[assembly: AssemblyDescription("Witty is a Twitter client for Windows 7, Vista and XP that is powered by the Windows Presentation Foundation (WPF)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Witty Twitter")]
[assembly: AssemblyProduct("Witty Twitter")]
[assembly: AssemblyCopyright("Copyright @  2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


// Specifies the location in which theme dictionaries are stored for types in an assembly.
[assembly: ThemeInfo(
    // Specifies the location of system theme-specific resource dictionaries for this project.
    // The default setting in this project is "None" since this default project does not
    // include these user-defined theme files:
    //     Themes\Aero.NormalColor.xaml
    //     Themes\Classic.xaml
    //     Themes\Luna.Homestead.xaml
    //     Themes\Luna.Metallic.xaml
    //     Themes\Luna.NormalColor.xaml
    //     Themes\Royale.NormalColor.xaml
    ResourceDictionaryLocation.None,

    // Specifies the location of the system non-theme specific resource dictionary:
    //     Themes\generic.xaml
    ResourceDictionaryLocation.SourceAssembly)]


// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("2.3.5.*")]
[assembly: log4net.Config.DOMConfigurator(ConfigFile = "App", ConfigFileExtension = "config", Watch = false)]
[assembly: GuidAttribute("E263B219-F3B5-4dd9-BC0D-39A5F2960459")]
[assembly: NeutralResourcesLanguageAttribute("en")]
