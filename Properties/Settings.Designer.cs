﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportsApplication4.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Provider=Advantage.OLEDB.1;Data Source=\\ESAL-WK-9BTJ5K3\C$\Medidata\Tutor;Persist Security Info=True;OLE DB Services=-13;Password=v632equ5o55nR;User ID=ADSSYS;Initial Catalog=\\ESAL-WK-9BTJ5K3\C$\Medidata\Tutor\mwddf.add;Mode=3;Advantage Security Mode=ADS_IGNORERIGHTS;Advantage Server Type=ADS_REMOTE_SERVER;Increment User Count=FALSE")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
           
         
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("\"Provider=Advantage.OLEDB.1;Data Source=C:\\\\Medidata\"")]
        public string ConnectionString1 {
            get {
                return ((string)(this["ConnectionString1"]));
            }
            set
            {
                ConnectionString1 = value;
            }
        }
    }
}
