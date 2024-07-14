using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using PR2024.Models;

namespace PR2024.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly Dictionary<string, Document> _documents = new Dictionary<string, Document>();

        public void CreateDocument(Document document)
        {
            if (_documents.ContainsKey(document.Id))
            {
                throw new Exception("Document with this ID already exists.");
            }
            _documents[document.Id] = document;
        }

        public Document ReadDocument(string id)
        {
            if (_documents.TryGetValue(id, out var document))
            {
                return document;
            }
            throw new Exception("Document not found.");
        }

        public void UpdateDocument(Document document)
        {
            if (!_documents.ContainsKey(document.Id))
            {
                throw new Exception("Document not found.");
            }
            _documents[document.Id] = document;
        }

        public void DeleteDocument(string id)
        {
            if (!_documents.ContainsKey(id))
            {
                throw new Exception("Document not found.");
            }
            _documents.Remove(id);
        }
    }

}
