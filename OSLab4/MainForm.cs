using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OSLab4
{
    public partial class MainForm : Form
    {
        List<List<int>> provided = new List<List<int>>();
        List<List<int>> maximum = new List<List<int>>();
        List<int> resources = new List<int>();
        List<int> freeResources = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetData(TextBox textBox, List<int> dataList)
        {
            try
            {
                string dataString = textBox.Text;
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    dataList.Add(Convert.ToInt32(withoutSpacesDataString[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void GetRichData(RichTextBox textBox, List<List<int>> dataList)
        {
            try
            {
                string dataString = textBox.Text;
                string[] splittedDataString = dataString.Split('\n');
                int numList = splittedDataString.Length;
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                for (int i = 0; i < numList; i++)
                {
                    dataList.Add(new List<int>());
                    string[] splittedAgainData = splittedDataString[i].Split(' ');
                    countSpaces = zero;
                    for (int l = 0; l < splittedAgainData.Length; l++)
                    {
                        if (splittedAgainData[l] != "")
                        {
                            countSpaces++;
                        }
                    }
                    if (countSpaces == zero)
                    {
                        MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                        return;
                    }
                    string[] withoutSpacesDataString = new string[countSpaces];
                    int j = 0;
                    for (int p = 0; p < splittedAgainData.Length; p++)
                    {
                        if (splittedAgainData[p] != "")
                        {
                            withoutSpacesDataString[j] = splittedAgainData[p];
                            j++;
                        }
                    }
                    for (int k = 0; k < withoutSpacesDataString.Length; k++)
                    {
                        dataList[i].Add(Convert.ToInt32(withoutSpacesDataString[k]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void ComputeFreeResources()
        {
            for(int i = 0; i < resources.Count; i++)
            {
                int temp = resources[i];
                for (int j = 0; j < provided.Count; j++)
                {
                    temp -= provided[j][i];
                }
                freeResources.Add(temp);
            }
            LogRichTextBox.Text += "Свободные ресурсы: \n";
            for (int i = 0; i < freeResources.Count; i++)
            {
                LogRichTextBox.Text += freeResources[i] + " ";
            }
            LogRichTextBox.Text += "\n";
        }

        private bool Computing(List<int> providedList, List<int> maximumList)
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < maximumList.Count; i++)
            {
                temp.Add(providedList[i] + freeResources[i]);
            }
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] < maximumList[i])
                {
                    return false;
                }
            }
            freeResources.Clear();
            foreach (var i in temp)
                freeResources.Add(i);
            return true;
        }

        private void Proccessing()
        {
            List<int> proccessID = new List<int>();
            for (int i = 0; i < provided.Count; i++)
                proccessID.Add(i + 1);
            for (int i = 0; i < provided.Count; i++)
            {
                if (Computing(provided[i], maximum[i]))
                {
                    LogRichTextBox.Text += "Процесс №" + proccessID[i] + " выполнен" + "\n";
                    LogRichTextBox.Text += "Свободные ресурсы: \n";
                    for (int j = 0; j < freeResources.Count; j++)
                        LogRichTextBox.Text += freeResources[j] + " ";
                    LogRichTextBox.Text += "\n";
                    provided.RemoveAt(i);
                    maximum.RemoveAt(i);
                    proccessID.RemoveAt(i);
                    i = -1;
                }
            }
            if (proccessID.Count == 0)
                LogRichTextBox.Text += "Состояние надежно";
            else
                LogRichTextBox.Text += "Состояние ненадежно";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            provided.Clear();
            maximum.Clear();
            resources.Clear();
            freeResources.Clear();
            LogRichTextBox.Clear();
            try
            {
                GetData(ResourceTextBox, resources);
                GetRichData(ProvidedRichTextBox, provided);
                GetRichData(MaximumRichTextBox, maximum);
                ComputeFreeResources();
                Proccessing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
