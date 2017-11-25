using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator_App.Classes
{
    class HtmlWriter
    {
        private string html;
        private string css;
        public string HTML
        {
            get
            {
                return "<style>\n" + css + "\n</style>\n" + html;
            }
        }
        public HtmlWriter()
        {
            css = "";
            html = "";
        }
        public string CreatePairedTag(string tag, string classes, string contents)
        {
            var html = "<" + tag + " class=\"" + classes + "\">\n" + contents + "\n</" + tag + ">\n";
            return html;
        }
        public string CreateLink(string href, string classes, string contents)
        {
            var link = "<a class=\"" + classes + "\" href=\"" + href + "\">" + contents + "</a>\n";
            return link;
        }
        public string CreateSingleTag(string tag, string classes)
        {
            var html = "<" + tag + " class=\"" + classes + "\">\n";
            return html;
        }
        public void AddTag(string tag)
        {
            this.html += tag;
        }
        public void AddCSSRule(string selector, string[] properties)
        {
            var css = selector + "{\n";
            foreach (string property in properties)
            {
                css += property + ";\n";
            }
            css += "}\n";
            this.css += css;

        }
    }
}
