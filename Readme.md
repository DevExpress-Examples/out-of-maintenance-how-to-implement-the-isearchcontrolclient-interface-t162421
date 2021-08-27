<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621372/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T162421)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FormSearchProvider.cs](./CS/FormSearchProvider.cs) (VB: [FormSearchProvider.vb](./VB/FormSearchProvider.vb))
* **[SearchForm.cs](./CS/SearchForm.cs) (VB: [SearchForm.vb](./VB/SearchForm.vb))**
<!-- default file list end -->
# How to implement the ISearchControlClient interface


<p>We have <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic">SearchControl</a> (added in v14.1), which provides the search and filter functionality for the attached object. <strong>SearchControl</strong> can be attached to objects that support the <strong>ISearchControlClient</strong> interface. You can find a list of our controls that support this interface out of the box in the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSearchControltopic">SearchControl</a> help topic.<br />However, this list can be extended by your own. This example illustrates how to implement the <strong>ISearchControlClient</strong> interface for a Form for searching and highlighting controls by their names.<br /><br />To introduce the <strong>ISearchControlClient</strong> interface into your project, implement the following members:<br /><strong> - SetSearchControl</strong> - this method is invoked when you attach/detach your object from the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsSearchControl_Clienttopic">SearchControl.Client</a> property.<br /><strong> - IsAttachedToSearchControl</strong> - this property determines whether your object is attached to SearchControl.<br /><strong> - ApplyFindFilter</strong> - this method is invoked when filtering is performed. Here you need to implement your own logic for filtering.<br /><strong> - CreateSearchProvider</strong> - this method must return SearchControlProviderBase's descendant. This provider contains SearchText and FilterCondition obtained from the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemSearchControl_FilterConditiontopic">RepositoryItemSearchControl.FilterCondition</a> property.<br />It is necessary to override the <strong>SearchControlProviderBase.GetCriteriaInfoCore</strong> method to return <strong>SearchInfoBase</strong>'s descendant. This instance should contain all required information for your filtering. It is passed to the <strong>ApplyFindFilter</strong> method as a parameter.<br /><br /><strong>See also: </strong><br /><a href="https://www.devexpress.com/Support/Center/p/T273248">How to support the ISearchControlClient interface for TileControl to use SearchControl with it</a></p>

<br/>


