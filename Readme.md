<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598290/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1007)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to add a datasource to the Component Tray and make it available in the Property Grid of the End-User Designer


<p>The following example demonstrates how to manually add components to the <i>designer host</i> of the End-User Report Designer. This may be required, for instance, if a report initially isn't bound to data, and data components are provided to it later - either after calling the <strong>XRDesignFormEx.OpenReport</strong> method or after clicking a custom button in the End-User Designer. In this case, data components will not be displayed in the Component Tray, and it will be impossible to assign them to a report's DataSource and DataAdapter properties until they are added to the <i>designer host</i>.</p>


<h3>Description</h3>

<p>To solve this task, it is necessary to handle the <strong>XRDesignFormEx.DesignPanel.DesignerHostLoaded</strong> event and call the <strong>RDesignToolHelper.AddToContainer</strong> method in this event handler for every data component, you want to add to the designer host.</p><p><strong>Note</strong>: If you want to remove any items from the designer host, call the <strong>DesignToolHelper.RemoveFromContainer</strong> method.</p>

<br/>


