using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Model;

namespace WPF_Telerik_Demo;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.BodyRichTextBox.ImageSelectionAdornerSettings.CanResize = false;
        this.BodyRichTextBox.Commands.OpenDocumentCommand.Enabled = false;
        this.BodyRichTextBox.Commands.NewDocumentCommand.Enabled = false;
        this.BodyRichTextBox.Commands.PrintCommand.Enabled = false;
        this.BodyRichTextBox.Commands.SaveCommand.Enabled = false;
        this.BodyRichTextBox.Commands.ShowFindReplaceDialogCommand.Enabled = false;
        this.BodyRichTextBox.DocumentInheritsDefaultStyleSettings = true;
        this.BodyRichTextBox.Commands.ChangeListStyleCommand.Enabled = false;
        this.BodyRichTextBox.DefaultStyleSettings.SetPropertyValue(Span.FontFamilyProperty, new FontFamily("Segoe UI"));
        this.BodyRichTextBox.DefaultStyleSettings.SetPropertyValue(Span.FontSizeProperty, 12);
        this.BodyRichTextBox.DefaultStyleSettings.SetPropertyValue(Paragraph.LineSpacingProperty, 1);
        this.BodyRichTextBox.DefaultStyleSettings.SetPropertyValue(Paragraph.LineSpacingTypeProperty, LineSpacingType.Auto);
        this.BodyRichTextBox.DefaultStyleSettings.SetPropertyValue(Paragraph.SpacingAfterProperty, 0);


    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.sourceCode.Text = this.htmlProvider.Html;
    }
}