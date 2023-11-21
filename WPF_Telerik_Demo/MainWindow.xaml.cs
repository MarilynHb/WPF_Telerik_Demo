using System.Windows;
using System.Windows.Media;
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
        this.BodyRichTextBox.FontFamily = new FontFamily("Segoe UI");
        this.BodyRichTextBox.FontSize = 12;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.sourceCode.Text = this.htmlProvider.Html;

    }

    private void htmlProvider_SetupDocument(object sender, Telerik.Windows.Documents.FormatProviders.SetupDocumentEventArgs e)
    {
        e.Document.ParagraphDefaultSpacingAfter = 0;
        e.Document.LineSpacingType = LineSpacingType.Auto;
        e.Document.LineSpacing = 1;
    }
}