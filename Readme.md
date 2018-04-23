# How to add a datasource to the Component Tray and make it available in the Property Grid of the End-User Designer


<p>The following example demonstrates how to manually add components to the <i>designer host</i> of the End-User Report Designer. This may be required, for instance, if a report initially isn't bound to data, and data components are provided to it later - either after calling the <strong>XRDesignFormEx.OpenReport</strong> method or after clicking a custom button in the End-User Designer. In this case, data components will not be displayed in the Component Tray, and it will be impossible to assign them to a report's DataSource and DataAdapter properties until they are added to the <i>designer host</i>.</p>

<br/>


