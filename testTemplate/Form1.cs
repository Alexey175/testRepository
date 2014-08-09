using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace testTemplate
{
    public partial class FormCreatorWord : Form
    {
        public FormCreatorWord()
        {
            InitializeComponent();
        }

        Word.Application oWord = new Word.Application();

        private void buttonCreateForm_Click(object sender, EventArgs e)
        {
            Document oDoc = GetDoc(Environment.CurrentDirectory + "\\testTemplate.dotx");
            oDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\testTemplateOutput.docx");
            oDoc.Close();
            
        }

        private Document GetDoc(string path)
        {
            Document oDoc = oWord.Documents.Add(path);
            SetTemplate(oDoc);
            return oDoc;
        }

        private void SetTemplate(Word.Document oDoc)
        {
            oDoc.Bookmarks["developed"].Range.Text = textBoxDeveloped.Text;
            oDoc.Bookmarks["checked"].Range.Text = textBoxChecked.Text;
            oDoc.Bookmarks["name"].Range.Text = textBoxName.Text;
            oDoc.Bookmarks["designation"].Range.Text = textBoxDesignation.Text;

        }

    }
}
