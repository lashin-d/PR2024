using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR2024.Models;


namespace PR2024.Services
{
    public interface IDocumentService
    {
        void CreateDocument(Document document);
        Document ReadDocument(string id);
        void UpdateDocument(Document document);
        void DeleteDocument(string id);
    }

}
