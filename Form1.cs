using System.Text;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lb1
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private int totalPages = 0;
        private int currentPage = 0;
        private int charactersPerPage = 0;
        private int charactersPerLine = 0;
        private long totalCharacters = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                string extension = Path.GetExtension(filePath);
                if (string.IsNullOrEmpty(extension) || extension.ToLower() != ".txt")
                {
                    MessageBox.Show("Выбранный файл не является текстовым файлом (.txt)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentPage = 0;
                int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedFontSize);
                richTextBox.Font = new Font("Lucida Console", selectedFontSize);
                totalCharacters = GetFileSize(filePath);
                LoadTextFromFile();
            }
        }
        private void LoadTextFromFile()
        {
            try
            {
                charactersPerPage = CalculateCharactersPerPage();
                totalPages = (int)Math.Ceiling((double)totalCharacters / charactersPerPage);
                CurrentPage();
                label3.Text = $"из {totalPages}";
                LoadPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CurrentPage() {
            if (currentPage == 0)
            {
                textBox1.Text = "1";
                currentPage = 1;

            }
            else if (currentPage > totalPages)
            {
                textBox1.Text = totalPages.ToString();
                currentPage = totalPages;
            }
        }
        private long GetFileSize(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
                int fileSize = fileContent.Length;
                return fileSize;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении размера файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private int CalculateCharactersPerPage()
        {
            Size textSize = TextRenderer.MeasureText("Съешь же ещё этих мягких французских булок, да выпей чаю.", richTextBox.Font);

            float lineHeight = textSize.Height;
            float textBoxHeight = richTextBox.Height - 1;
            int linesCount = (int)(textBoxHeight / lineHeight);

            float charWidth = textSize.Width / 57;

            float textBoxWidth = richTextBox.Width;
            charactersPerLine = (int)(textBoxWidth / charWidth);

            return (linesCount * charactersPerLine);
        }
        private void LoadPage()
        {
            int pageNumber;

            if (int.TryParse(textBox1.Text, out pageNumber) && pageNumber >= 1 && pageNumber <= totalPages)
            {
                int startIndex = (pageNumber - 1) * charactersPerPage;
                UpdateButtonsState();

                string text = ReadTextFromFile(filePath, startIndex);
                richTextBox.Text = text;
            }
            else
            {
                MessageBox.Show($"Номер страницы должен быть в диапазоне от 1 до {totalPages}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrentPage();
            }
        }
        private string ReadTextFromFile(string filePath, int startIndex)
        {
            try
            {
                string text = "";
                StringBuilder result = new StringBuilder();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int currentIndex = 0;
                    while (currentIndex < startIndex && !reader.EndOfStream)
                    {
                        char currentChar = (char)reader.Read();
                        currentIndex++;

                    }
                    int charactersRead = 0;
                    while (charactersRead < charactersPerPage && !reader.EndOfStream)
                    {
                        char currentChar = (char)reader.Read();
                        if (currentChar != '\r' && currentChar != '\n')
                        {
                            text += currentChar;
                            charactersRead++;
                        }
                        else
                        {
                            text += ' ';
                            charactersRead++;
                        }

                        if (charactersRead % charactersPerLine == 0 && charactersRead != charactersPerPage)
                        {
                            text += '\n';
                        }
                    }
                }
                return text;
            }
            catch (Exception ex)
            {
                ButtonsDisabled();
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedFontSize))
            {
                richTextBox.Font = new Font("Lucida Console", selectedFontSize);
                LoadTextFromFile();
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBox1.Text, out int pageNumber) && pageNumber >= 1 && pageNumber <= totalPages)
                {
                    currentPage = pageNumber;
                    LoadPage();
                }
                else
                {   
                    MessageBox.Show($"Номер страницы должен быть в диапазоне от 1 до {totalPages}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CurrentPage();
                }
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int pageNumber) && pageNumber >= 1 && pageNumber <= totalPages)
            {
                currentPage = pageNumber;
                LoadPage();
            }
            else
            {
                MessageBox.Show($"Номер страницы должен быть в диапазоне от 1 до {totalPages}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrentPage();
            }
        }
        private void richTextBox_Resize(object sender, EventArgs e)
        {
            if (currentPage != 0)
            {
                LoadTextFromFile();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                textBox1.Text = currentPage.ToString();
                LoadPage();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                textBox1.Text = currentPage.ToString();
                LoadPage();
            }
        }
        private void UpdateButtonsState()
        {
            button2.Enabled = currentPage > 1;
            button3.Enabled = currentPage < totalPages && currentPage > 0;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void ButtonsDisabled()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
        }

    }
}