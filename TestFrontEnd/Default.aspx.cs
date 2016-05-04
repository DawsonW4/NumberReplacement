using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestLib;

namespace TestFrontEnd
{
    public partial class _Default : Page
    {
        public static Dictionary<int, string> divisibleDictionary = new Dictionary<int, string>();
        private static string[] resultList;

        protected void Page_Load(object sender, EventArgs e)
        {
            btn_AddDivisible.Click += Btn_AddDivisibleClick;
            btn_CountNumbers.Click += Btn_GetNumbers;
            divisibleListView.PagePropertiesChanging += OnDivisibleListViewPropertiesChanging;
            numberCountListView.PagePropertiesChanging += OnCountListViewPropertiesChanging;

            statusLabel.Text = "";
        }

        #region "Button Events"
        void Btn_AddDivisibleClick(Object sender, EventArgs e)
        {
            if (text_divisibleBy.Text != "" && text_replacementString.Text != "")
            {
                var listSearch = from item in divisibleDictionary
                                 where text_divisibleBy.Text == item.Key.ToString()
                                 select item;

                if (listSearch.Count() == 0)
                    divisibleDictionary.Add(int.Parse(text_divisibleBy.Text), text_replacementString.Text);
            }

            divisibleListView.DataSource = divisibleDictionary;
            divisibleListView.DataBind();
        }

        void Btn_GetNumbers(Object sender, EventArgs e)
        {
            if(text_MinimumNumber.Text != "" && text_MaximumNumber.Text != "")
                resultList = PrintClass.PrintNumbers(int.Parse(text_MinimumNumber.Text), int.Parse(text_MaximumNumber.Text), divisibleDictionary);

            numberCountListView.DataSource = resultList;
            numberCountListView.DataBind();
        }
        #endregion

        #region "PropertiesChanging Events for Paginations"
        protected void OnDivisibleListViewPropertiesChanging(object sender, PagePropertiesChangingEventArgs e)

        {
            (divisibleListView.FindControl("divisibleListViewPager") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            divisibleListView.DataSource = divisibleDictionary;
            divisibleListView.DataBind();
        }

        protected void OnCountListViewPropertiesChanging(object sender, PagePropertiesChangingEventArgs e)

        {
            (numberCountListView.FindControl("CountListViewPager") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            numberCountListView.DataSource = resultList;
            numberCountListView.DataBind();
        }
        #endregion
    }
}