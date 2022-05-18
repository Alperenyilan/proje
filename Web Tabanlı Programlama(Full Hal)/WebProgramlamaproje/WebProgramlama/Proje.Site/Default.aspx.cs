using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelSlider1.Text = "Explore";
            LabelDesc1.Text = "Explore dozens of creative image and stock footages or give people clue about your passionate!";
            LabelSlider2.Text = "Inspire";
            LabelDesc2.Text ="Take inspiration from choosen images or help community to take their roadmap for future works or projects!";
            LabelSlider3.Text = "Share";
            LabelDesc3.Text ="Share your example work/works with footage deposit to contribute enlargement of image world!";

        }
    }
}