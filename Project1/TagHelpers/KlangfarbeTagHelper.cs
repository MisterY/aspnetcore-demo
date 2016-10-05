using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.TagHelpers
{
    [HtmlTargetElement("img", Attributes = "my-url")]
    public class KlangfarbeTagHelper : TagHelper
    {
        [HtmlAttributeName("my-url")]
        public string Url { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            //output.Attributes["src"]. = ;
            //output.Attributes.Clear();
            output.Attributes.Add("src", "https://www.klangfarbe.com/bilder/A/A-A41554-1-2.jpg");
        }
    }
}
