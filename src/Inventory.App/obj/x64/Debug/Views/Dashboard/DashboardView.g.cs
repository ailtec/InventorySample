﻿#pragma checksum "C:\Users\ALI\Documents\Mega\GitHub\InventorySample\src\Inventory.App\Views\Dashboard\DashboardView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16A20FF4399CD20A4B6621B1AEF66B2E1FF50B2FC1D1AA7CBF7934A1FEA5B3D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.Views
{
    partial class DashboardView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Inventory_Views_CustomersPane_ItemsSource(global::Inventory.Views.CustomersPane obj, global::System.Collections.Generic.IList<global::Inventory.Models.CustomerModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::Inventory.Models.CustomerModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::Inventory.Models.CustomerModel>), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Inventory_Views_ProductsPane_ItemsSource(global::Inventory.Views.ProductsPane obj, global::System.Collections.Generic.IList<global::Inventory.Models.ProductModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::Inventory.Models.ProductModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::Inventory.Models.ProductModel>), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Inventory_Views_OrdersPane_ItemsSource(global::Inventory.Views.OrdersPane obj, global::System.Collections.Generic.IList<global::Inventory.Models.OrderModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.IList<global::Inventory.Models.OrderModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.IList<global::Inventory.Models.OrderModel>), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class DashboardView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IDashboardView_Bindings
        {
            private global::Inventory.Views.DashboardView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Inventory.Views.CustomersPane obj3;
            private global::Inventory.Views.ProductsPane obj4;
            private global::Inventory.Views.OrdersPane obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;
            private static bool isobj5ItemsSourceDisabled = false;

            private DashboardView_obj1_BindingsTracking bindingsTracking;

            public DashboardView_obj1_Bindings()
            {
                this.bindingsTracking = new DashboardView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 48 && columnNumber == 42)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 54 && columnNumber == 41)
                {
                    isobj4ItemsSourceDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 39)
                {
                    isobj5ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\Dashboard\DashboardView.xaml line 45
                        this.obj3 = (global::Inventory.Views.CustomersPane)target;
                        break;
                    case 4: // Views\Dashboard\DashboardView.xaml line 51
                        this.obj4 = (global::Inventory.Views.ProductsPane)target;
                        break;
                    case 5: // Views\Dashboard\DashboardView.xaml line 57
                        this.obj5 = (global::Inventory.Views.OrdersPane)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IDashboardView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Inventory.Views.DashboardView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Inventory.Views.DashboardView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Inventory.ViewModels.DashboardViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Customers(obj.Customers, phase);
                        this.Update_ViewModel_Products(obj.Products, phase);
                        this.Update_ViewModel_Orders(obj.Orders, phase);
                    }
                }
            }
            private void Update_ViewModel_Customers(global::System.Collections.Generic.IList<global::Inventory.Models.CustomerModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Dashboard\DashboardView.xaml line 45
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Inventory_Views_CustomersPane_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Products(global::System.Collections.Generic.IList<global::Inventory.Models.ProductModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Dashboard\DashboardView.xaml line 51
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Inventory_Views_ProductsPane_ItemsSource(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Orders(global::System.Collections.Generic.IList<global::Inventory.Models.OrderModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Dashboard\DashboardView.xaml line 57
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Inventory_Views_OrdersPane_ItemsSource(this.obj5, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class DashboardView_obj1_BindingsTracking
            {
                private global::System.WeakReference<DashboardView_obj1_Bindings> weakRefToBindingObj; 

                public DashboardView_obj1_BindingsTracking(DashboardView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<DashboardView_obj1_Bindings>(obj);
                }

                public DashboardView_obj1_Bindings TryGetBindingObject()
                {
                    DashboardView_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    DashboardView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Inventory.ViewModels.DashboardViewModel obj = sender as global::Inventory.ViewModels.DashboardViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Customers(obj.Customers, DATA_CHANGED);
                                bindings.Update_ViewModel_Products(obj.Products, DATA_CHANGED);
                                bindings.Update_ViewModel_Orders(obj.Orders, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Customers":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Customers(obj.Customers, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Products":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Products(obj.Products, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Orders":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Orders(obj.Orders, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Inventory.ViewModels.DashboardViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Inventory.ViewModels.DashboardViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Dashboard\DashboardView.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.GridView element2 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element2).ItemClick += this.OnItemClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Dashboard\DashboardView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    DashboardView_obj1_Bindings bindings = new DashboardView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

