using Compito_15_09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Compito_15_09
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
                UpdateProductCount();
            }
        }
        protected void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int productId = Convert.ToInt32(btn.CommandArgument);

                
                Product productToRemove = Cart.Products.FirstOrDefault(p => p.Id == productId);
                if (productToRemove != null)
                {
                    Cart.Products.Remove(productToRemove);
                }

                Response.Redirect(Request.RawUrl);
                BindCart();
            }
        }
        private void BindCart()
        {
            
            GridViewCart.DataSource = Cart.Products;
            GridViewCart.DataBind();
        }
        protected void btnBackToProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        private void UpdateProductCount()
        {
            int productCount = Cart.Products.Count; 
            lblProductCount.Text = productCount.ToString(); 
        }
    }

}