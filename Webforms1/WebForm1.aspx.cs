using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms1
{
    /*
    Note till magistern & erik(eftersom att du kollar min kod) :

    Att skriva kod är inget problem men att skriva smart kod är ngt som jag
    inte har kommit på än. Jag kör en massa if else för att det var enklast
    när jag började skriva men kom snabbt på att switch med ett antal case
    hade kunnat vara smidigare
    */
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            string outputUnit = dd1.SelectedItem.Text;
            if (outputUnit.Equals("mm"))
            {
                GetMM();
            }
            else if (outputUnit.Equals("cm"))
            {
                GetCM();
            }
            else if (outputUnit.Equals("dm"))
            {
                GetDM();
            }
            else if (outputUnit.Equals("m"))
            {
                GetM();
            }
            else if (outputUnit.Equals("km"))
            {
                GetKM();
            }
            else if (outputUnit.Equals("mil"))
            {
                GetMIL();
            }
        }

        private void GetMM()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal*0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mm" && outputUnit == "dm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal*0.01;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mm" && outputUnit == "m")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal*0.001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mm" && outputUnit == "km")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal*0.000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mm" && outputUnit == "mil")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal*0.0000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

        private void GetCM()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "cm" && outputUnit == "dm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.01;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "cm" && outputUnit == "km")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.00001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "cm" && outputUnit == "mil")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

        private void GetDM()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "dm" && outputUnit == "mm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.01;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "dm" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "dm" && outputUnit == "m")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "dm" && outputUnit == "km")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.0001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "dm" && outputUnit == "mil")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.00001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

        private void GetM()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "m" && outputUnit == "mm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "m" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.01;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "m" && outputUnit == "dm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "m" && outputUnit == "km")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "m" && outputUnit == "mil")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.0001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

        private void GetKM()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "km" && outputUnit == "mm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "km" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.00001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "km" && outputUnit == "dm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.0001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "km" && outputUnit == "m")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "km" && outputUnit == "mil")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal * 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

        private void GetMIL()
        {
            string inputVal = input.Text;
            string inputUnit = dd1.SelectedValue;
            string outputUnit = dd2.SelectedValue;
            string outputText = output.Text;
            double numberVal;
            double result;

            if (dd1.SelectedItem.Text.Equals(dd2.SelectedItem.Text))
            {
                output.Text = "Same unit entered";
            }
            else if (inputUnit == "mil" && outputUnit == "mm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.0000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mil" && outputUnit == "cm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.000001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mil" && outputUnit == "dm")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.00001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mil" && outputUnit == "m")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.0001;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
            else if (inputUnit == "mil" && outputUnit == "km")
            {
                double.TryParse(inputVal, out numberVal);
                result = numberVal / 0.1;
                output.Text = $"{inputVal}{inputUnit} = {result}{outputUnit}";
            }
        }

    }
}