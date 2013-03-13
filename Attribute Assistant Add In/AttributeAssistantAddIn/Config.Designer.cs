//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArcGIS4LocalGovernment {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "Attribute Assistant";
            }
        }
        
        internal static string AddInID {
            get {
                return "{5CAD338F-775E-44D8-A342-8DC123BF8E7B}";
            }
        }
        
        internal static string Company {
            get {
                return "Esri., Inc.";
            }
        }
        
        internal static string Version {
            get {
                return "10.1.1.7";
            }
        }
        
        internal static string Description {
            get {
                return "Allows attributes to be automatically populated as features are created or modifi" +
                    "ed based on a series of user defined rules.";
            }
        }
        
        internal static string Author {
            get {
                return "Esri., Inc.";
            }
        }
        
        internal static string Date {
            get {
                return "3/5/2013";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantEditorExtension', the id declared for Add-in Extension class 'AttributeAssistantEditorExtension'
            /// </summary>
            internal static string AttributeAssistantEditorExtension {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantEditorExtension";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantToggleCommand', the id declared for Add-in Button class 'AttributeAssistantToggleCommand'
            /// </summary>
            internal static string AttributeAssistantToggleCommand {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantToggleCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_RunChangeRulesCommand', the id declared for Add-in Button class 'RunChangeRulesCommand'
            /// </summary>
            internal static string RunChangeRulesCommand {
                get {
                    return "ArcGIS4LocalGovernment_RunChangeRulesCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_RunChangeGeoRulesCommand', the id declared for Add-in Button class 'RunChangeGeoRulesCommand'
            /// </summary>
            internal static string RunChangeGeoRulesCommand {
                get {
                    return "ArcGIS4LocalGovernment_RunChangeGeoRulesCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_RunManualRulesCommand', the id declared for Add-in Button class 'RunManualRulesCommand'
            /// </summary>
            internal static string RunManualRulesCommand {
                get {
                    return "ArcGIS4LocalGovernment_RunManualRulesCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_RunCreateRulesCommand', the id declared for Add-in Button class 'RunCreateRulesCommand'
            /// </summary>
            internal static string RunCreateRulesCommand {
                get {
                    return "ArcGIS4LocalGovernment_RunCreateRulesCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantSuspendOffCommand', the id declared for Add-in Button class 'AttributeAssistantSuspendOffCommand'
            /// </summary>
            internal static string AttributeAssistantSuspendOffCommand {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantSuspendOffCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantSuspendOnCommand', the id declared for Add-in Button class 'AttributeAssistantSuspendOnCommand'
            /// </summary>
            internal static string AttributeAssistantSuspendOnCommand {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantSuspendOnCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantSuspendCommand', the id declared for Add-in Button class 'AttributeAssistantSuspendCommand'
            /// </summary>
            internal static string AttributeAssistantSuspendCommand {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantSuspendCommand";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_AttributeAssistantLoadLastValue', the id declared for Add-in Button class 'AttributeAssistantLoadLastValue'
            /// </summary>
            internal static string AttributeAssistantLoadLastValue {
                get {
                    return "ArcGIS4LocalGovernment_AttributeAssistantLoadLastValue";
                }
            }
            
            /// <summary>
            /// Returns 'ArcGIS4LocalGovernment_ShowConfigForm', the id declared for Add-in Button class 'ShowConfigForm'
            /// </summary>
            internal static string ShowConfigForm {
                get {
                    return "ArcGIS4LocalGovernment_ShowConfigForm";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
