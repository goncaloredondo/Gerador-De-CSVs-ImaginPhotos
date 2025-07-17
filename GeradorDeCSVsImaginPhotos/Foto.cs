using GData;
using System.Collections.Generic;
using System.Drawing;

namespace GeradorDeCSVsImaginPhotos
{
    internal class Foto
    {
        private List<Atributo> atributos;
        public List<Atributo> Atributos { get => atributos; set => atributos = value; }
        public Foto()
        {

        }
        public Foto(Image img, string autor, string categoria, string descricao, string nome, string tipo, string url)
        {
            int fileNameIndex = 0, formatIndex = 0;
            string formato="", nomeFicheiro="", orientacao="", resolucao=img.Width + "x" + img.Height;
            for (int i = url.Length - 1; url[i] != '.'; i--)
            {
                formatIndex = i;
            }
            for (int i = formatIndex; i < url.Length; i++)
            {
                formato += url.ToUpper()[i];
            }
            if (img.Width > img.Height)
            {
                orientacao = "Horizontal";
            }
            else if (img.Width < img.Height)
            {
                orientacao = "Vertical";
            }
            img = null;
            for (int i = url.Length - 1; url[i] != '/'; i--)
            {
                fileNameIndex = i;
            }
            for (int i = fileNameIndex; i < url.Length; i++)
            {
                nomeFicheiro += url[i];
            }
            atributos = new List<Atributo>();
            atributos.Add(new Atributo("ID", ""));
            atributos.Add(new Atributo("Tipo", "simple, downloadable, virtual"));
            atributos.Add(new Atributo("REF", ""));
            atributos.Add(new Atributo("GTIN, UPC, EAN, or ISBN", ""));
            atributos.Add(new Atributo("Nome", nome));
            atributos.Add(new Atributo("Publicado", "1"));
            atributos.Add(new Atributo("Em destaque?", "0"));
            atributos.Add(new Atributo("Visibilidade no catálogo", "visible"));
            atributos.Add(new Atributo("Descrição breve", ""));
            atributos.Add(new Atributo("Descrição", descricao));
            atributos.Add(new Atributo("Data de início do preço promocional", ""));
            atributos.Add(new Atributo("Data de término do preço promocional", ""));
            atributos.Add(new Atributo("Situação fiscal", "taxable"));
            atributos.Add(new Atributo("Classe de imposto", ""));
            atributos.Add(new Atributo("Em stock?", "1"));
            atributos.Add(new Atributo("Stock", ""));
            atributos.Add(new Atributo("Valor de stock baixo", ""));
            atributos.Add(new Atributo("Permitir encomendas pendentes?", "0"));
            atributos.Add(new Atributo("Vender Individualmente?", "1"));
            atributos.Add(new Atributo("Peso (kg)", ""));
            atributos.Add(new Atributo("Comprimento (cm)", ""));
            atributos.Add(new Atributo("Largura (cm)", ""));
            atributos.Add(new Atributo("Altura (cm)", ""));
            atributos.Add(new Atributo("Permitir avaliações de clientes?", "0"));
            atributos.Add(new Atributo("Nota da encomenda", ""));
            atributos.Add(new Atributo("Preço promocional", ""));
            atributos.Add(new Atributo("Preço normal", "2.0"));
            atributos.Add(new Atributo("Categorias", categoria));
            atributos.Add(new Atributo("Etiquetas", ""));
            atributos.Add(new Atributo("Classe de envio", ""));
            atributos.Add(new Atributo("Imagens", url));
            atributos.Add(new Atributo("Limite de descarregamento", "1"));
            atributos.Add(new Atributo("Dias para expirar o descarregamento", "30"));
            atributos.Add(new Atributo("Pai", ""));
            atributos.Add(new Atributo("Produtos agrupados", ""));
            atributos.Add(new Atributo("Aumenta vendas", ""));
            atributos.Add(new Atributo("Vendas cruzadas", ""));
            atributos.Add(new Atributo("URL externo", ""));
            atributos.Add(new Atributo("Texto do botão", ""));
            atributos.Add(new Atributo("Posição", "0"));
            atributos.Add(new Atributo("Marcas", ""));
            atributos.Add(new Atributo("Download 1 ID", ""));
            atributos.Add(new Atributo("Descarregar 1 nome", nomeFicheiro));
            atributos.Add(new Atributo("Descarregar 1 URL", url));
            atributos.Add(new Atributo("Atributo 1 nome", "Formato"));
            atributos.Add(new Atributo("Atributo 1 valor(es)", formato));
            atributos.Add(new Atributo("Atributo 1 visível", "1"));
            atributos.Add(new Atributo("Atributo 1 global", "1"));
            atributos.Add(new Atributo("Atributo 2 nome", "Licença"));
            atributos.Add(new Atributo("Atributo 2 valor(es)", "Uso Pessoal e Comercial"));
            atributos.Add(new Atributo("Atributo 2 visível", "1"));
            atributos.Add(new Atributo("Atributo 2 global", "1"));
            atributos.Add(new Atributo("Atributo 3 nome", "Orientação"));
            atributos.Add(new Atributo("Atributo 3 valor(es)", orientacao));
            atributos.Add(new Atributo("Atributo 3 visível", "1"));
            atributos.Add(new Atributo("Atributo 3 global", "1"));
            atributos.Add(new Atributo("Atributo 4 nome", "Resolução"));
            atributos.Add(new Atributo("Atributo 4 valor(es)", resolucao));
            atributos.Add(new Atributo("Atributo 4 visível", "1"));
            atributos.Add(new Atributo("Atributo 4 global", "1"));
            atributos.Add(new Atributo("Atributo 5 nome", "Tipo"));
            atributos.Add(new Atributo("Atributo 5 valor(es)", tipo));
            atributos.Add(new Atributo("Atributo 5 visível", "1"));
            atributos.Add(new Atributo("Atributo 5 global", "1"));
            atributos.Add(new Atributo("Atributo 6 nome", "Autor"));
            atributos.Add(new Atributo("Atributo 6 valor(es)", autor));
            atributos.Add(new Atributo("Atributo 6 visível", "1"));
            atributos.Add(new Atributo("Atributo 6 global", "1"));
            atributos.Add(new Atributo("Metadados: _aviaLayoutBuilder_active", ""));
            atributos.Add(new Atributo("Metadados: _avia_sc_parser_state", "check_only"));
            atributos.Add(new Atributo("Metadados: _custom_layout_post_id", ""));
            atributos.Add(new Atributo("Metadados: _aviaLayoutBuilderCleanData", ""));
            atributos.Add(new Atributo("Metadados: _av_el_mgr_version", "1.0"));
            atributos.Add(new Atributo("Metadados: layout", ""));
            atributos.Add(new Atributo("Metadados: sidebar", ""));
            atributos.Add(new Atributo("Metadados: footer", "nofooterwidgets"));
            atributos.Add(new Atributo("Metadados: footer_behavior", ""));
            atributos.Add(new Atributo("Metadados: header_title_bar", ""));
            atributos.Add(new Atributo("Metadados: header_transparency", ""));
            atributos.Add(new Atributo("Metadados: _product_hover", ""));
            atributos.Add(new Atributo("Metadados: _yoast_wpseo_primary_product_brand", ""));
            atributos.Add(new Atributo("Metadados: _yoast_wpseo_primary_product_cat", ""));
            atributos.Add(new Atributo("Metadados: _yoast_wpseo_content_score", ""));
            atributos.Add(new Atributo("Metadados: _yoast_wpseo_estimated-reading-time-minutes", ""));
        }
    }
}