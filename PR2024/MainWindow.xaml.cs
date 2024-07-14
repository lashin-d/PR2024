using System.Windows;
using PR2024.Models;
using PR2024.Services;

namespace PR2024
{
    public partial class MainWindow : Window
    {
        private readonly IDocumentService _documentService = new DocumentService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var document = new Document
                {
                    Id = DocumentIdTextBox.Text,
                    Content = DocumentContentTextBox.Text
                };
                _documentService.CreateDocument(document);
                ResultTextBlock.Text = "Document created successfully.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var document = _documentService.ReadDocument(DocumentIdTextBox.Text);
                DocumentContentTextBox.Text = document.Content;
                ResultTextBlock.Text = "Document read successfully.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var document = new Document
                {
                    Id = DocumentIdTextBox.Text,
                    Content = DocumentContentTextBox.Text
                };
                _documentService.UpdateDocument(document);
                ResultTextBlock.Text = "Document updated successfully.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _documentService.DeleteDocument(DocumentIdTextBox.Text);
                DocumentContentTextBox.Text = string.Empty;
                ResultTextBlock.Text = "Document deleted successfully.";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }
    }

}
