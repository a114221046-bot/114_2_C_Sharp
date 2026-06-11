using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // struct 用來儲存單一筆摩斯密碼資料
        // - Character: 對應的字元，例如 'A', '1', 等
        // - Code: 對應的摩斯表示法，例如 ".-" 或 "-...."
        // 使用 struct 是題目要求，並用 List<MorseEntry> 儲存完整表
        private struct MorseEntry
        {
            public char Character;
            public string Code;
        }

        // 儲存整個摩斯密碼表（不要使用 Dictionary，使用 List）
        private List<MorseEntry> morseTable;

        public Form1()
        {
            InitializeComponent();
        }

        // Form load 時初始化並讀取外部的 morse_code_table.md
        private void Form1_Load(object sender, EventArgs e)
        {
            morseTable = new List<MorseEntry>();

            // 將檔案放在應用程式的執行目錄中（exe 同目錄）
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDir, "morse_code_table.md");

            if (!File.Exists(filePath))
            {
                // 若找不到檔案則顯示錯誤訊息並結束載入流程
                MessageBox.Show($"找不到檔案: {filePath}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 使用題目指定的方式讀取檔案：File.OpenText() 回傳 StreamReader
                // 並以 !inputFile.EndOfStream 判斷是否尚有未讀取的資料
                using (StreamReader inputFile = File.OpenText(filePath))
                {
                    while (!inputFile.EndOfStream)
                    {
                        // 逐行讀取檔案內容
                        string line = inputFile.ReadLine();

                        // 忽略空行
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        // 期待 Markdown 表格格式（包含 | 分隔），若無則略過
                        if (!line.Contains("|"))
                            continue;

                        string[] parts = line.Split('|');
                        if (parts.Length < 3)
                            continue;

                        // 從分割後的欄位中找出字元欄與摩斯碼欄
                        // 會略過表頭（例如 'Character' 或 'Morse'）
                        string charPart = null;
                        string codePart = null;
                        for (int i = 0; i < parts.Length; i++)
                        {
                            string p = parts[i].Trim();
                            if (string.IsNullOrEmpty(p))
                                continue;

                            // 若為表頭文字則視為此列不是資料列，跳出
                            if (p.Equals("Character", StringComparison.OrdinalIgnoreCase) || p.Equals("Morse", StringComparison.OrdinalIgnoreCase) || p.Equals("Char", StringComparison.OrdinalIgnoreCase))
                            {
                                charPart = null;
                                codePart = null;
                                break;
                            }

                            // 第一個非空欄視為字元欄，第二個非空欄視為摩斯碼欄
                            if (charPart == null)
                            {
                                charPart = p;
                            }
                            else
                            {
                                codePart = p;
                            }
                        }

                        if (string.IsNullOrEmpty(charPart) || string.IsNullOrEmpty(codePart))
                            continue;

                        // 取字元欄的第一個字元作為 key
                        char ch = charPart[0];

                        // 清理摩斯碼欄位（例如刪除 Markdown 的反引號 ` ）
                        string code = codePart.Replace("`", "").Trim();

                        // 建立 struct 並加入 List
                        MorseEntry entry = new MorseEntry { Character = ch, Code = code };
                        morseTable.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                // 讀檔或解析發生例外時提示使用者
                MessageBox.Show("讀取摩斯密碼表時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (morseTable.Count == 0)
            {
                // 若最後沒有讀入任何條目，提示使用者檢查檔案格式
                MessageBox.Show("摩斯密碼表為空或格式錯誤。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 使用者按下「轉換」按鈕時的處理
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("請先輸入要轉換的文字。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // fullBuilder 用來組出整段的摩斯密碼字串（字母間以空白分隔）
            StringBuilder fullBuilder = new StringBuilder();
            // mapping 將放到 txtMapping（逐字列出原字與摩斯碼的對應）
            StringBuilder mappingBuilder = new StringBuilder();
            txtMapping.Clear();

            foreach (char raw in input)
            {
                // 保留換行與回車，使輸出對應輸入的段落
                if (raw == '\r' || raw == '\n')
                {
                    // 保留段落分隔
                    fullBuilder.AppendLine();
                    // 在 listBox 中加入空行以保留段落
                    mappingBuilder.AppendLine();
                    continue;
                }

                // 空白字元使用斜線 '/' 表示字詞間隔（常見慣例），並在 mapping 中標示為 (space)
                if (raw == ' ')
                {
                    // 空白字元轉為 '/' 作為字詞間隔，並在對照清單加入對應
                    fullBuilder.Append("/ ");
                    mappingBuilder.AppendLine("(space) => /");
                    continue;
                }

                // 在 morseTable 中搜尋對應的條目（不使用 Dictionary，採逐一比對，且不分大小寫）
                MorseEntry? found = null;
                char upper = char.ToUpperInvariant(raw);
                foreach (var eEntry in morseTable)
                {
                    if (char.ToUpperInvariant(eEntry.Character) == upper)
                    {
                        found = eEntry;
                        break;
                    }
                }

                if (found.HasValue)
                {
                    // 找到對應的摩斯碼，加入到完整輸出，並在逐字對照的 listBox 中加入一筆
                    fullBuilder.Append(found.Value.Code);
                    fullBuilder.Append(' ');
                    mappingBuilder.AppendLine($"{char.ToUpperInvariant(raw)} => {found.Value.Code}");
                }
                else
                {
                    // 未定義於 morse_code_table.md 的字元會被忽略（不輸出、不列入對照）
                    continue;
                }
            }

            // 將建構好的結果顯示在畫面上的只讀文字框
            txtFull.Text = fullBuilder.ToString().TrimEnd();
            txtMapping.Text = mappingBuilder.ToString().TrimEnd();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFull_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 清除輸入與輸出文字框的內容
            txtInput.Clear();
            txtFull.Clear();
            txtMapping.Clear();

            // 將焦點回到輸入框，方便使用者繼續輸入
            txtInput.Focus();
        }
    }
}
