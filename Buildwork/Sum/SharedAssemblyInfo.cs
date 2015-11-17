using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Keysight Technologies")]
[assembly: AssemblyProduct("E7530A/E7630A LTE/LTE-A Application")]
[assembly: AssemblyCopyright("")] // Format as per http://emg.communications.keysight.com/marketing/brand/docs/copyright_format.pdf
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
#if FORMAL_RELEASE
// Formal/official builds use a fixed version notation.
[assembly: AssemblyVersion("12.23.44.555")]
#else
// Informal/unofficial builds use the "*" notation
[assembly: AssemblyVersion( "1.1.*" )]
#endif

