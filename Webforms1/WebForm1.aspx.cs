using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //dd2.SelectedIndexChanged +=
                //new EventHandler(OutputUnit_SelectedValueChanged);
        }

        //private void OutputUnit_SelectedValueChanged(object sender, EventArgs e)
        private void ConverterMethod()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (inputUnit.Equals(outputUnit))
            {
                outputText = "Same Value entered";
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.1;
                outputText = result.ToString();
            }
        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text == "mm" && dd2.SelectedItem.Text == "mm")
            {
                output.Text = "Same Value entered";
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.1;
                output.Text = $"{result}{outputUnit}";
            }
        }
    }
}