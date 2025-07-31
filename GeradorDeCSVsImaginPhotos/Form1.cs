using GData;
using HtmlAgilityPack;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
namespace GeradorDeCSVsImaginPhotos
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        Image img;
        List<Foto> lstFotos = new List<Foto>();
        List<string> fotosHeader = new List<string>(), arrLines = new List<string>();
        Regex reg1 = new Regex(@"\d{2}x\d{2}"), reg2 = new Regex(@"\d{3}x\d{3}"), reg3 = new Regex(@"\d{3}x\d{4}"), reg4 = new Regex(@"\d{4}x\d{4}"), reg5 = new Regex(@"\d{4}x\d{3}"), reg6 = new Regex(@"scaled");
        string domain = "/*Dominio utilizado*/", fotoUrl = "";
        private static string programPath = Application.StartupPath;
        public Form1()
        {
            // Configurar o serviço IHttpClientFactory
            var services = new ServiceCollection();
            object value = services.AddHttpClient();
            _serviceProvider = services.BuildServiceProvider();
            PreencherFotos("/*url da página com as imagens*/");
        }
        public async Task PreencherFotos(string rootPath)
        {
            List<string> lstFotosUrl = await ListarSubItemsAsync(rootPath);
            InitializeComponent();
            SubItemsCreator(lstFotosUrl);
            ControlsCreator();
        }
        private async Task<List<string>> ListarSubItemsAsync(string url)
        {
            List<string> lstSubItems = new List<string>();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(await new HtmlHttp(_serviceProvider.GetRequiredService<IHttpClientFactory>()).GetHtmlAsStringAsync(url));
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string href = link.GetAttributeValue("href", "");
                if (href.Contains("jpg") && !href.Contains("-1.jpg"))
                {
                    if (!reg1.IsMatch(href) && !reg2.IsMatch(href) && !reg3.IsMatch(href) && !reg4.IsMatch(href) && !reg5.IsMatch(href) && !reg6.IsMatch(href) && !href.Contains("banner"))
                    {
                        lstSubItems.Add(domain+href);
                    }
                }
            }
            return lstSubItems;
        }
        void SubItemsCreator(List<string> urlList)
        {
            int fileNameIndex = 0;
            foreach(string fotoUrl in urlList)
            {
                bool ficheiroEncontrado = false;
                string nomeFicheiro = "";
                for (int i = fotoUrl.Length - 1; fotoUrl[i] != '/'; i--)
                {
                    fileNameIndex = i;
                }
                for (int i = fileNameIndex; i < fotoUrl.Length; i++)
                {
                    nomeFicheiro += fotoUrl[i];
                }
                if (ficheiroEncontrado == false)
                {
                    cbFotos.Items.Add(new Item(nomeFicheiro, fotoUrl));
                }
            }
            Item itm1 = new Item("Não", "0");
            Item itm2 = new Item("Sim", "1");
            cbCategorias.Items.Add(new Item("Escolha uma categoria",""));
            cbCategorias.Items.Add(new Item("Ambientes Internos", "Ambientes internos"));
            cbCategorias.Items.Add(new Item("Ar Livre", "Ar livre"));
            cbCategorias.Items.Add(new Item("Arquitetura", "Arquitetura"));
            cbCategorias.Items.Add(new Item("Documental", "Documental"));
            cbCategorias.Items.Add(new Item("Estruturas", "Estruturas"));
            cbCategorias.Items.Add(new Item("MacroFotografia", "Macro"));
            cbCategorias.Items.Add(new Item("Minimalista", "Minimalista"));
            cbCategorias.Items.Add(new Item("Monocromáticas", "Monocromaticas"));
            cbCategorias.Items.Add(new Item("Natureza Morta", "Natureza Morta"));
            cbCategorias.Items.Add(new Item("Noturnas", "Noturnas"));
            cbCategorias.Items.Add(new Item("Paisagem", "Paisagem"));
            cbTipo.Items.Add(new Item("Escolha o tipo", ""));
            cbTipo.Items.Add(new Item("Fotografia", "Fotografia"));
        }
        private void button_Click(object sender, EventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "btnAdicionar":
                    lstFotos.Add(new Foto(img, txtAutor.Text, (cbCategorias.SelectedItem as Item).Value as string, rtbDescricao.Text, txtNome.Text, (cbTipo.SelectedItem as Item).Value as string, fotoUrl));
                    cbFotos.Items.RemoveAt(cbFotos.SelectedIndex);
                    txtNome.Text = "";
                    cbCategorias.SelectedIndex = 0;
                    cbTipo.SelectedIndex = 0;
                    rtbDescricao.Text = "";
                    txtAutor.Text = "";
                    pbFoto.Image = null;
                    break;
                case "btnCriarCSV":
                    var caminho = programPath+"\\ListaDeFotos.csv";
                    using (var writer = new StreamWriter(caminho, false, new UTF8Encoding(false)))
                    {
                        foreach (Foto ft in lstFotos)
                        {
                            List<string> fotoLine = new List<string>();
                            if (fotosHeader.Count == 0)
                            {
                                foreach (Atributo atr in ft.Atributos)
                                {
                                    fotosHeader.Add($"\"{atr.Nome}\"");
                                }
                            }
                            foreach (Atributo atr in ft.Atributos)
                            {
                                fotoLine.Add($"\"{atr.Valor.Replace("\"", "\"\"")}\"");
                            }
                            arrLines.Add(string.Join(",", fotoLine));
                        }
                        writer.WriteLine(string.Join(",", fotosHeader));
                        foreach (string line in arrLines)
                        {
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("CSV Criado com sucesso! 😊");
                    lstFotos = new List<Foto>();
                    break;
            }
        }
        private void comboBox_SelectedIndex(object sender, EventArgs e)
        {
            switch((sender as ComboBox).Name)
            {
                case "cbFotos":
                    cbCategorias.SelectedIndex = 0;
                    cbTipo.SelectedIndex = 0;
                    fotoUrl = (cbFotos.SelectedItem as Item).Value as string;
                    img = Image.FromStream(new MemoryStream(new System.Net.WebClient().DownloadData(fotoUrl)));
                    pbFoto.Image = img;
                    break;
            }
        }
    }
}