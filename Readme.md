<!-- default file list -->
*Files to look at*:

* [Converter.cs](./CS/RibbonSample/Converter.cs) (VB: [Converter.vb](./VB/RibbonSample/Converter.vb))
* **[MainWindow.xaml](./CS/RibbonSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/RibbonSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/RibbonSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RibbonSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to add a horizontal offset to the RibbonControl page headers


<p>This example illustrates how to change the RibbonControl appearance by adding a horizontal offset for displayed pages.</p><p>To accomplish this task, customize the "{dxrt:RibbonPageThemeKey ResourceKey=PageHeaderTemplate}" TargetType="{x:Type dxr:RibbonPageHeaderControl}" template and set binding with your own converter to the margin property of the RibbonPageCaptionControl.</p><p>Then, register an attached PageOffset property that will store the necessary offset.</p>

<br/>


