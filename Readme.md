

# Multiple selection using checkbox (web style)

Starting with version **13.2**, <strong>GridView</strong> provides a built-in checkbox column for multiple row selection. So, to enable this type of multiple row selection in newer versions, it is sufficient to enable the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect.property"><strong>GridViewOptionsSelection.MultiSelect</strong></a><strong> </strong>option and then set the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode.property"><strong>GridView.OptionsSelection.MultiSelectMode</strong></a><strong> </strong>property to the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.enum"><strong>GridMultiSelectMode.CheckBoxRowSelect</strong></a><strong> </strong>value. Take a look at the <strong><a href="https://www.devexpress.com/Support/Center/p/E990">How to use an unbound check box column to select grid rows</a> </strong>example for sample code.

Starting with version **18.1**, in multiple row selection mode, you can sync row selected states with a Boolean field in the bound data source. The selection binding mode ensures that row selection persists whenever you filter or group grid data. Refer to the [Multiple Row Selection via Built-In Check Column and Selection Binding](https://documentation.devexpress.com/WindowsForms/16439/Controls-and-Libraries/Data-Grid/Focus-and-Selection-Handling/Multiple-Row-Selection-via-Built-In-Check-Column-and-Selection-Binding) help article for more information.

## ***If the built-in CheckBox column does not suit you, we will be happy to find the most appropriate solution for you if you describe your real-life scenario. Just click   [here](https://www.devexpress.com/Support/Center/Question/Create) to submit a ticket to our Support Center.***

