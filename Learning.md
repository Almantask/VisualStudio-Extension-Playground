# Learning

Or how I created a playground to try building my own VS Extension.

## 1. Understanding what I need

https://learn.microsoft.com/en-us/visualstudio/extensibility/visual-studio-sdk?view=vs-2022

Helped me figure out I need a tool window - a readonly window to just display some stats.

## 2. Following tutorial wasn't successful

To build a tool window - I followed this tutorial.

https://learn.microsoft.com/en-us/visualstudio/extensibility/adding-a-tool-window?view=vs-2022

Did not produce good results - build failed and in fact the tutorial was flawed.

## 3. Started fresh in baby steps

I ran what comes with VSIX template and just tried to understand how that works before proceeding.

## 4. Documenting what I have

Grid with stack pannel in which there is a button. I don't need any of that.
Ended up with:

<UserControl x:Class="SandboxVsExtension.SandboxWindowControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
             xmlns:vsshell="clr-namespace:Microsoft.VisualStudio.Shell;assembly=Microsoft.VisualStudio.Shell.15.0"
             Background="{DynamicResource {x:Static vsshell:VsBrushes.WindowKey}}"
             Foreground="{DynamicResource {x:Static vsshell:VsBrushes.WindowTextKey}}"
             mc:Ignorable="d"
             d:DesignHeight="300" d:DesignWidth="300"
             Name="MyToolWindow">
    <Grid>
        <ListView d:ItemsSource="{d:SampleData ItemCount=5}" Margin="0,12,0,0">
            <ListView.View>
                <GridView>
                    <GridViewColumn/>
                </GridView>
            </ListView.View>
        </ListView>
        <Button Content="Refresh" Click="Refresh_Click" Width="60" Height="23" x:Name="Refresh" VerticalAlignment="Bottom" HorizontalAlignment="Right"/>
    </Grid>
</UserControl>

## 5. PoC with cmd