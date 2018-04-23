# How to add a horizontal offset to the RibbonControl page headers


<p>This example illustrates how to change the RibbonControl appearance by adding a horizontal offset for displayed pages.</p><p>To accomplish this task, customize the "{dxrt:RibbonPageThemeKey ResourceKey=PageHeaderTemplate}" TargetType="{x:Type dxr:RibbonPageHeaderControl}" template and set binding with your own converter to the margin property of the RibbonPageCaptionControl.</p><p>Then, register an attached PageOffset property that will store the necessary offset.</p>

<br/>


