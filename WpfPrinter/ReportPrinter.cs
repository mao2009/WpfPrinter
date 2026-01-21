using System;
using System.Collections.Generic;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using WpfPrinter.Interfaces;

namespace WpfPrinter
{
    public static class ReportPrinter
    {
        /// <summary>
        /// Prints the specified document.
        /// </summary>
        /// <param name="doc">The document to print.</param>
        /// <exception cref="ArgumentNullException">Thrown when the document is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the document is not a FixedDocument.</exception>
        /// <remarks>
        /// This method displays a print dialog and prints the document if the user confirms.
        /// </remarks>
        /// <example>
        /// <code>
        /// var doc = new FixedDocument();
        /// ReportPrinter.Print(doc);
        /// </code>
        /// </example>
        public static void Print(FixedDocument doc, bool isPortrait, string name)
        {
            var dlg = new PrintDialog()
            {
                PrintTicket = new PrintTicket()
                {
                    PageOrientation = isPortrait ? PageOrientation.Portrait : PageOrientation.Landscape,
                }
            };

            if (dlg.ShowDialog() == true)
            {
                dlg.PrintTicket.PageOrientation = isPortrait ? PageOrientation.Portrait : PageOrientation.Landscape;
                var duc_ = (IDocumentPaginatorSource)doc;
                try
                {
                    if (duc_ == null)
                    {
                        throw new InvalidOperationException("The document is not a FixedDocument.");
                    }

                    dlg.PrintDocument(duc_.DocumentPaginator, name);
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException(nameof(doc), "The document cannot be null.");
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("The document must implement IDocumentPaginatorSource.");
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while printing the document.", ex);
                }
            }
        }

        public static PrintDialog ShowPrintDialog(bool isPortrait)
        {
            return new PrintDialog()
            {
                PrintTicket = new PrintTicket()
                {
                    PageOrientation = isPortrait ? PageOrientation.Portrait : PageOrientation.Landscape,
                }
            };
        }

        public static void Print(PrintDialog dlg, FixedDocument doc, bool isPortrait, string name)
        {
            dlg.PrintTicket.PageOrientation = isPortrait ? PageOrientation.Portrait : PageOrientation.Landscape;
            var duc_ = (IDocumentPaginatorSource)doc;
            try
            {
                if (duc_ == null)
                {
                    throw new InvalidOperationException("The document is not a FixedDocument.");
                }

                dlg.PrintDocument(duc_.DocumentPaginator, name);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(doc), "The document cannot be null.");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("The document must implement IDocumentPaginatorSource.");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while printing the document.", ex);
            }
        }

        public static FixedDocument LayoutsToDoc<T>(List<IReportLayout> layouts, bool addingBlank=true) where T : IReportItemLayoutViewModel, new()
        {
            var fixedDoc = new FixedDocument();

            foreach (var layout in layouts)
            {
                if (addingBlank)
                {
                    var blankCount = layout.MaxItemCount - layout.Details.Count;

                    for (var i = 0; i < blankCount; i++)
                    {
                        layout.Details.Add(new T());
                    }
                }
                
                // Measure/Arrange は印刷用のレイアウトには必須
                layout.Measure(new Size(layout.Width, layout.Height));
                layout.Arrange(new Rect(new Size(layout.Width, layout.Height)));

                layout.UpdateLayout();

                // UserControl を FixedPage に追加
                var fixedPage = new FixedPage
                {
                    Width = layout.Width,
                    Height = layout.Height
                };


                fixedPage.Children.Add((UIElement)layout);

                var pageContent = new PageContent();
                ((IAddChild)pageContent).AddChild(fixedPage);
                fixedDoc.Pages.Add(pageContent);
            }

            return fixedDoc;
        }
    }
}