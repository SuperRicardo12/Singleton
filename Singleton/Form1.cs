using System;
using System.Windows.Forms;
using SingletonLib; 

namespace Singleton
{
    public partial class Form1 : Form
    {
        private DbManager dbManager = DbManager.GetInstance();
        private DocumentSaver documentSaver = DocumentSaver.GetInstance();
        private Logger logger = Logger.GetInstance();
        private bool isDbConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.Log("Програма запущена.");
            btnSaveDocument.Enabled = false;
        }

        private void btnConnectDb_Click(object sender, EventArgs e)
        {
            dbManager.Connect();
            isDbConnected = true;  
            logger.Log("Підключено до бази даних.");
            lstLogs.Items.Add("Підключено до бази даних.");
            btnSaveDocument.Enabled = true;

        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            string documentName = txtDocument.Text;
            if (!string.IsNullOrWhiteSpace(documentName))
            {
                documentSaver.SaveDocument(documentName);
                logger.Log($"Документ '{documentName}' збережено.");
                lstLogs.Items.Add($"Документ '{documentName}' збережено.");
            }
            else
            {
                MessageBox.Show("Введіть назву документа!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            lstLogs.Items.Add("Перегляд логів:");
            foreach (var log in logger.GetLogs())
            {
                lstLogs.Items.Add(log);
            }
            logger.Log("Переглянуто логи.");
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

