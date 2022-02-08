<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632513/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1271)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Windows Forms - Multiple row selection using checkboxes (web style row selection)

## Built-in Checkbox Column
In version 13.2 and higher, Data Grid supports a built-in checkbox column for multiple row selection in grid Views. To activate this checkbox column, enable the [GridView.OptionsSelection.MultiSelect](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect.property) option, and set the [GridView.OptionsSelection.MultiSelectMode](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode.property) property to `CheckBoxRowSelect`. 

Starting with version 18.1, you can sync row selected states with a Boolean field in the bound data source. Checkbox column bound mode ensures that row selection persists whenever you filter or group grid data.

See the following topic for more information: [Multiple Row Selection via Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding).
 
## Custom Checkbox Column
This example shows how you can create a custom checkbox column to select rows in Data Grid. The checkbox column's header and group rows display check marks that allow users to toggle selection of all rows and row groups, respectively.
  
<img src="https://raw.githubusercontent.com/DevExpress-Examples/multiple-selection-using-checkbox-web-style-e1271/13.1.4+/media/17ac6e9d-e756-49eb-8d10-b57b281569cd.png">

The `GridCheckMarksSelection` class adds a checkbox column to a target grid View, implements the row selection functionality, and exposes methods to work with the row selection in code.

<!-- default file list -->
## Files to Look At

* [CheckMarkSelection.cs](./CS/E1271/CheckMarkSelection.cs) (VB: [CheckMarkSelection.vb](./VB/E1271/CheckMarkSelection.vb))

<!-- default file list end -->


## Documentation
- [GridView.OptionsSelection.MultiSelect](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect.property)
- [GridView.OptionsSelection.MultiSelectMode](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode.property)
- [Multiple Row Selection via Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding)

## See Also
- [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)


