using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace InventorySystem.Controllers
{
  
    public class ZambeziController : Controller
    {
        SqlConnection con = new SqlConnection("");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RecordsAClass()
        {

            /*
            PdfWriter writer = new PdfWriter("./");
            PdfDocument pdf = new PdfDocument(writer);
            Document document= new Document(pdf);

            Paragraph header1 = new Paragraph("REBULIC OF NAMIBIA");
            Paragraph header2 = new Paragraph("MAIN REGISTER");

            Table table = new Table(16, true);
            Cell cell1 = new Cell(1,8).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("ICN"));
            Cell cell2 = new Cell(1, 4).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Part No"));
            Cell cell3 = new Cell(1, 4).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Part No"));
            Cell cell4 = new Cell(1, 8).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Description"));
            Cell cell5 = new Cell(1, 4).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Application"));
            Cell cell6 = new Cell(1, 4).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Location"));
            Cell cell7 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Category"));
            Cell cell8 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Min"));
            Cell cell9 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Max"));
            Cell cell10 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Average Usage"));
            Cell cell11 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("DOQ"));
            Cell cell12 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Price"));
            Cell cell13 = new Cell(1, 8).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Opened by"));
            Cell cell14 = new Cell(1, 8).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Authorized by"));
            Cell cell15 = new Cell(1, 2).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Date"));
            Cell cell16 = new Cell(1, 2).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Voucher"));
            Cell cell17 = new Cell(1, 3).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("From/To"));
            Cell cell18 = new Cell(1, 2).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).Add(new Paragraph("Recieved"));

            table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);
            table.AddCell(cell4);
            table.AddCell(cell5);
            table.AddCell(cell6);
            table.AddCell(cell7);
            table.AddCell(cell8);
            table.AddCell(cell9);
            table.AddCell(cell10);
            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);
            table.AddCell(cell14);
            table.AddCell(cell15);
            table.AddCell(cell16);
            table.AddCell(cell17);
            table.AddCell(cell18);

            string conn = "SELECT * FROM ..";
            SqlCommand cmd = new SqlCommand(conn, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
                
                while(rdr.Read())
                {
                    table.AddCell(rdr.GetString(0));
                    table.AddCell(rdr.GetString(1));
                    table.AddCell(rdr.GetString(2));
                    table.AddCell(rdr.GetString(3));
                    table.AddCell(rdr.GetString(4));
                    table.AddCell(rdr.GetString(5));
                    table.AddCell(rdr.GetString(6));
                    table.AddCell(rdr.GetString(7));
                    table.AddCell(rdr.GetString(8));
                    table.AddCell(rdr.GetString(9));
                    table.AddCell(rdr.GetString(10));
                    table.AddCell(rdr.GetString(11));

                document.Add(table);
                }
                document.Close();
            byte[] filebytes = System.IO.File.ReadAllBytes("./");
            return File(filebytes,"Register","Register.pdf");
            */
            return View();
        }
    }
}
