# How to create a Outlook demo using WPF TreeView (SfTreeView)?

## About the sample

This sample illustrates how to create a Outlook demo using SfTreeView.

SfTreeView allows to customize the appearance of each item with different templates based on specific constraints by using the ItemTemplateSelector. To customize the SfTreeView to get an outlook like appearance, you can create and choose different DataTemplate for expander and the mail item at runtime using ItemTemplateSelector.

```Xaml

<Window.Resources>
    <BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter" />
    <local:BoolToVisibilityMultiConverter x:Key="BoolToVisibilityMultiConverter" />
    <DataTemplate x:Key="descriptionTemplate">
        <Border BorderBrush="Gray" BorderThickness="0,0,0,1">
                <Grid Height="60">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="20" />
                        <ColumnDefinition />
                    </Grid.ColumnDefinitions>
                <ToggleButton
                                HorizontalAlignment="Left"
                                Background="#FFB1D6F0"
                                IsChecked="{Binding IsUnRead, Mode=TwoWay}"
                        Visibility="Visible">
                    <ToggleButton.Style>
                            <Style TargetType="ToggleButton">
                                <Style.Triggers>
                                    <Trigger Property="IsChecked" Value="True">
                                        <Setter Property="Background" Value="Red" />
                                    </Trigger>
                                    <Trigger Property="IsMouseOver" Value="True">
                                        <Setter Property="Width" Value="14" />
                                    </Trigger>
                                </Style.Triggers>
                                <Setter Property="FocusVisualStyle" Value="{x:Null}" />
                                <Setter Property="Template">
                                    <Setter.Value>
                                        <ControlTemplate TargetType="{x:Type ToggleButton}">
                                            <Border
                                                        x:Name="border"
                                                        Width="10"
                                                        Background="{TemplateBinding Background}"
                                                        BorderBrush="{TemplateBinding BorderBrush}"
                                                        BorderThickness="0"
                                                        SnapsToDevicePixels="True">
                                                <ContentPresenter
                                                            x:Name="contentPresenter"
                                                            Margin="{TemplateBinding Padding}"
                                                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
                                                            Content="{TemplateBinding Content}"
                                                            ContentStringFormat="{TemplateBinding ContentStringFormat}"
                                                            ContentTemplate="{TemplateBinding ContentTemplate}"
                                                            Focusable="False"
                                                            RecognizesAccessKey="True"
                                                            SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}" />
                                            </Border>
                                            <ControlTemplate.Triggers>
                                                <Trigger Property="Button.IsDefaulted" Value="True">
                                                    <Setter TargetName="border" Property="BorderBrush" Value="{DynamicResource {x:Static SystemColors.HighlightBrushKey}}" />
                                                </Trigger>
                                                <Trigger Property="IsMouseOver" Value="True">
                                                    <Setter Property="Width" Value="14" />
                                                    <Setter TargetName="border" Property="Width" Value="14" />
                                                </Trigger>
                                                <Trigger Property="IsPressed" Value="True">
                                                    <Setter TargetName="border" Property="Background" Value="#FF0067B0" />
                                                    <Setter TargetName="border" Property="BorderBrush" Value="#FF2C628B" />
                                                </Trigger>
                                                <Trigger Property="IsChecked" Value="True">
                                                    <Setter TargetName="border" Property="Background" Value="#FF0067B0" />
                                                    <Setter TargetName="border" Property="BorderBrush" Value="#FF245A83" />
                                                </Trigger>
                                                <Trigger Property="IsEnabled" Value="False">
                                                    <Setter TargetName="border" Property="Background" Value="#FFF4F4F4" />
                                                    <Setter TargetName="border" Property="BorderBrush" Value="#FFADB2B5" />
                                                    <Setter TargetName="contentPresenter" Property="TextElement.Foreground" Value="#FF838383" />
                                                </Trigger>
                                            </ControlTemplate.Triggers>
                                        </ControlTemplate>
                                    </Setter.Value>
                                </Setter>
                            </Style>
                        </ToggleButton.Style>
                    </ToggleButton>
                    <Grid Grid.Column="1">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="30*" />
                            <RowDefinition Height="30*" />
                            <RowDefinition Height="30*" />
                        </Grid.RowDefinitions>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="70*" />
                            <ColumnDefinition Width="20*" />
                            <ColumnDefinition Width="10*" />
                        </Grid.ColumnDefinitions>
                    <TextBlock FontWeight="Bold" Text="{Binding SenderDetails}" />
                        <TextBlock
                                    Grid.Row="1"
                                    FontWeight="SemiBold"
                                    Text="{Binding Subject}"
                                    TextTrimming="WordEllipsis" />
                        <TextBlock
                                    Grid.Row="2"
                                    Foreground="Gray"
                                    Text="{Binding Message}"
                                    TextTrimming="WordEllipsis" />
                        <Label
                                    Grid.Row="1"
                                    Grid.Column="1"
                                    Height="30"
                                    Content="{Binding Date}" />
                        <ToggleButton
                                    Grid.Column="1"
                                    IsChecked="{Binding IsFlagged}"
                                    Visibility="Visible">
                            <ToggleButton.Content>
                                <Path
                                            Width="14"
                                            Height="14"
                                            Data="M0,1.5480409L2.9240003,1.5480409 2.9240003,44.879043 0,44.879043z M13.070206,1.0048421E-05C19.906545,-0.0069781953,25.467971,3.6343748,
                                    34.017987,0.52327134L34.017987,18.413837C22.617967,22.564965,16.525987,14.707729,5.650989,19.503865L5.650989,1.6083267C8.3709896,0.41004016,10.791426,0.0023394859,13.070206,1.0048421E-05z"
                                            Fill="{Binding Foreground, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType=ToggleButton}}"
                                            RenderTransformOrigin="0.5,0.5"
                                            Stretch="Uniform">
                                    <Path.RenderTransform>
                                        <TransformGroup>
                                            <TransformGroup.Children>
                                                <RotateTransform Angle="0" />
                                                <ScaleTransform ScaleX="1" ScaleY="1" />
                                            </TransformGroup.Children>
                                        </TransformGroup>
                                    </Path.RenderTransform>
                                </Path>
                            </ToggleButton.Content>
                            <ToggleButton.Style>
                                <Style TargetType="ToggleButton">
                                    <Setter Property="Template">
                                        <Setter.Value>
                                            <ControlTemplate TargetType="{x:Type ToggleButton}">
                                                <ContentPresenter
                                                            Margin="{TemplateBinding Padding}"
                                                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
                                                            RecognizesAccessKey="True"
                                                            SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}"
                                                            TextElement.FontFamily="Calibri"
                                                            TextElement.FontSize="23" />
                                                <ControlTemplate.Triggers>
                                                    <Trigger Property="IsEnabled" Value="false">
                                                        <Setter Property="Foreground" Value="#ADADAD" />
                                                    </Trigger>
                                                    <Trigger Property="IsMouseOver" Value="True">
                                                        <Setter Property="Foreground" Value="Red" />
                                                    </Trigger>
                                                    <Trigger Property="IsChecked" Value="True">
                                                        <Setter Property="Foreground" Value="Red" />
                                                    </Trigger>
                                                </ControlTemplate.Triggers>
                                            </ControlTemplate>
                                        </Setter.Value>
                                    </Setter>
                                    <Style.Triggers>
                                        <Trigger Property="IsMouseOver" Value="True">
                                            <Setter Property="Background" Value="Red" />
                                        </Trigger>
                                    </Style.Triggers>
                                </Style>
                            </ToggleButton.Style>
                        </ToggleButton>
                        <Button
                                    Grid.Row="1"
                                    Grid.Column="2"
                            Visibility="{Binding IsMouseOver, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType=syncfusion:TreeNodeView}, 
                                        Converter={StaticResource BooleanToVisibilityConverter}}" >
                            <Button.Content>
                                <Path
                                            Data="F1M108.574,147.6743C108.299,147.1563,107.995,146.3563,107.463,145.4933C107.206,145.0533,106.928,144.5763,106.634,144.0723C106.351,143.5563,105.965,143.0763,105.611,142.5423C104.915,141.4593,104.007,140.4343,103.139,139.3563C102.944,139.1543,102.752,138.9513,102.558,138.7473C102.849,138.4333,103.137,138.1113,103.443,137.8333C103.895,
                                    137.4113,104.298,136.9553,104.745,136.6033C105.184,136.2373,105.599,135.8903,105.982,135.5713C106.737,134.9083,107.46,134.4863,107.926,134.1273C108.407,133.7863,108.681,133.5923,108.681,133.5923C108.681,133.5923,108.379,133.7373,107.849,133.9933C107.331,134.2683,106.531,134.5723,105.668,135.1043C105.228,135.3613,104.752,135.6393,104.247,135.9333C103.732,
                                    136.2153,103.252,136.6023,102.717,136.9563C102.342,137.1973,101.979,137.4853,101.613,137.7663C101.171,137.3143,100.725,136.8753,100.26,136.4863C99.763,136.0603,99.327,135.6083,98.827,135.2493C98.338,134.8773,97.875,134.5253,97.448,134.2003C97.114,133.9383,96.618,133.5973,96.135,133.2763C95.329,132.7403,94.238,133.0093,93.78,133.8613L93.763,133.8933C93.31,
                                    134.7353,93.671,135.7813,94.545,136.1693C95.08,136.4063,95.617,136.6563,95.932,136.8333C96.35,137.0523,96.802,137.2903,97.281,137.5413C97.77,137.7763,98.248,138.1323,98.767,138.4433C99.134,138.6563,99.491,138.9153,99.85,139.1673C99.743,139.2543,99.639,139.3403,99.531,139.4273C98.544,140.3823,97.498,141.3063,96.662,142.3073C96.236,142.8033,95.783,143.2403,
                                    95.424,143.7403C95.052,144.2293,94.7,144.6923,94.376,145.1193C94.114,145.4533,93.772,145.9483,93.451,146.4323C92.916,147.2373,93.185,148.3283,94.037,148.7873L94.068,148.8043C94.91,149.2573,95.956,148.8953,96.344,148.0213C96.582,147.4863,96.832,146.9493,97.009,146.6343C97.228,146.2173,97.465,145.7643,97.717,145.2863C97.951,144.7973,98.307,144.3193,
                                    98.618,143.7993C99.232,142.7423,100.052,141.7363,100.829,140.6753C100.974,140.5123,101.116,140.3473,101.26,140.1823C101.471,140.3413,101.677,140.4973,101.892,140.6543C102.865,141.5213,103.901,142.3513,104.733,143.2683C105.155,143.7193,105.611,144.1233,105.963,144.5703C106.33,145.0093,106.676,145.4233,106.996,145.8063C107.659,146.5623,108.08,147.2843,
                                    108.44,147.7513C108.78,148.2313,108.975,148.5063,108.975,148.5063C108.975,148.5063,108.829,148.2033,108.574,147.6743"
                                            Fill="{Binding Foreground, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType=Button}}"
                                        
                                            RenderTransformOrigin="0.5,0.5"
                                            Stretch="Uniform">
                                    <Path.RenderTransform>
                                        <TransformGroup>
                                            <TransformGroup.Children>
                                                <RotateTransform Angle="0" />
                                                <ScaleTransform ScaleX="1" ScaleY="1" />
                                            </TransformGroup.Children>
                                        </TransformGroup>
                                    </Path.RenderTransform>
                                </Path>
                            </Button.Content>
                            <Button.Style>
                                <Style TargetType="Button">
                                    <Setter Property="Template">
                                        <Setter.Value>
                                            <ControlTemplate TargetType="{x:Type Button}">
                                                <ContentPresenter
                                                            Margin="{TemplateBinding Padding}"
                                                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
                                                            RecognizesAccessKey="True"
                                                            SnapsToDevicePixels="{TemplateBinding SnapsToDevicePixels}"
                                                            TextElement.FontFamily="Calibri"
                                                            TextElement.FontSize="23" />
                                                <ControlTemplate.Triggers>
                                                    <Trigger Property="IsEnabled" Value="false">
                                                        <Setter Property="Foreground" Value="#ADADAD" />
                                                    </Trigger>
                                                    <Trigger Property="IsMouseOver" Value="True">
                                                        <Setter Property="Foreground" Value="Red" />
                                                    </Trigger>
                                                </ControlTemplate.Triggers>
                                            </ControlTemplate>
                                        </Setter.Value>
                                    </Setter>
                                    <Style.Triggers>
                                        <Trigger Property="IsMouseOver" Value="True">
                                            <Setter Property="Background" Value="Red" />
                                        </Trigger>
                                    </Style.Triggers>
                                </Style>
                            </Button.Style>
                        </Button>
                    </Grid>
                </Grid>
            </Border>

        </DataTemplate>
    <DataTemplate x:Key="headerTemplate">
        <Grid x:Name="grid">
            <Grid Grid.Row="0">
                <Grid Margin="1,0,0,0"
                                          VerticalAlignment="Center">
                    <Label Content="{Binding Header}"
                                               FontSize="11"
                                               FontWeight="Bold"
                                               VerticalContentAlignment="Center" />
                </Grid>
            </Grid>
        </Grid>
    </DataTemplate>
    <local:ItemTemplateSelector x:Key="itemTemplateSelector"/>
</Window.Resources>
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition/>
    </Grid.RowDefinitions>

    <syncfusion:SfTreeView x:Name="sfTreeView" Grid.Row="1"
                           ChildPropertyName="MailCollection"
                           FullRowSelect="True"
                           AutoExpandMode="RootNodes"
                           ItemsSource="{Binding SelectedMailCollection}" 
                           ItemTemplateSelector="{StaticResource itemTemplateSelector}" 
                           ExpanderWidth="20" IsAnimationEnabled="True"
                           QueryNodeSize="SfTreeView_QueryNodeSize">
    </syncfusion:SfTreeView>
</Grid>

```

```c#

class ItemTemplateSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        var treeviewNode = item as TreeViewNode;
        if (treeviewNode == null)
            return null;
        if (treeviewNode.Level == 0)
            return Application.Current.MainWindow.FindResource("headerTemplate") as DataTemplate;
        else
            return Application.Current.MainWindow.FindResource("descriptionTemplate") as DataTemplate;
    }
}

```

![SfTreeView with Outlook appearance](OutlookImage.png)

KB article - [How to create a Outlook demo using WPF TreeView (SfTreeView)?](https://www.syncfusion.com/kb/11983/how-to-create-a-outlook-demo-using-wpf-treeview-sftreeview)

## Requirements to run the demo
Visual Studio 2015 and above versions
