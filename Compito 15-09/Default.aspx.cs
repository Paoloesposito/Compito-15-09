using Compito_15_09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Compito_15_09
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProducts();
                UpdateProductCount();
            }
        }

        
        private void BindProducts()
        {
            ProductRepeater.DataSource = GetSampleProducts();
            ProductRepeater.DataBind();
        }


        private List<Product> GetSampleProducts()
        {
    

            return new List<Product>
            {
                new Product
    {
        Id = 1,
        Name = "Smartphone Apple iPhone 13",
        Description = "Smartphone con display OLED da 6.1 pollici, doppia fotocamera e chip A15 Bionic.",
        Price = 899.00M,
        ImageUrl = "images/iphone13.jpg"
    },
    new Product
    {
        Id = 2,
        Name = "Tostapane Philips HD2581/00",
        Description = "Tostapane compatto con 8 impostazioni di tostatura e 2 grandi slot.",
        Price = 24.99M,
        ImageUrl = "images/Tostapane philips.jpg"
    },
    new Product
    {
        Id = 3,
        Name = "Caffettiera Moka Bialetti 6 Tazze",
        Description = "Caffettiera classica in alluminio per un caffè ricco e aromatico.",
        Price = 29.99M,
        ImageUrl = "images/Moka.jpg"
    },
    new Product
    {
        Id = 4,
        Name = "Scarpe da corsa Nike Air Zoom",
        Description = "Scarpe da corsa leggere con tecnologia Air Zoom per il massimo comfort.",
        Price = 119.50M,
        ImageUrl = "images/Air Zoom.jpg"
    },
    new Product
    {
        Id = 5,
        Name = "Libro 'Il nome della rosa' di Umberto Eco",
        Description = "Un thriller medievale che combina un'analisi penetrante della fede e della eresia con un mistero ad alta tensione.",
        Price = 10.90M,
        ImageUrl = "url/to/image/libro.jpg"
    },
    new Product
    {
        Id = 6,
        Name = "Console PlayStation 5",
        Description = "La console di nuova generazione di Sony, con tempi di caricamento ultra-rapidi e grafica di alta qualità.",
        Price = 499.99M,
        ImageUrl = "url/to/image/ps5.jpg"
    },
    new Product
    {
        Id = 7,
        Name = "Frullatore a immersione Braun",
        Description = "Frullatore a immersione potente e versatile, ideale per salse, zuppe e frullati.",
        Price = 44.99M,
        ImageUrl = "url/to/image/frullatore.jpg"
    },
    new Product
    {
        Id = 8,
        Name = "Orologio da polso Casio Vintage",
        Description = "Orologio digitale dal design retrò, con cinturino in acciaio inossidabile.",
        Price = 49.00M,
        ImageUrl = "url/to/image/orologio.jpg"
    },
    new Product
    {
        Id = 9,
        Name = "Cuffie Bluetooth Sony WH-1000XM4",
        Description = "Cuffie over-ear con cancellazione del rumore e una durata della batteria di 30 ore.",
        Price = 279.00M,
        ImageUrl = "url/to/image/cuffie.jpg"
    },
    new Product
    {
        Id = 10,
        Name = "Borsa Gucci Marmont",
        Description = "Borsa di lusso in pelle con logo GG sulla parte anteriore.",
        Price = 980.00M,
        ImageUrl = "url/to/image/borsa.jpg"
    },
    new Product
    {
        Id = 11,
        Name = "Fotocamera Canon EOS M50",
        Description = "Fotocamera mirrorless compatta con sensore CMOS da 24.1 MP e video 4K.",
        Price = 649.99M,
        ImageUrl = "url/to/image/canon.jpg"
    },
    new Product
    {
        Id = 12,
        Name = "Macchina da caffè Nespresso",
        Description = "Macchina da caffè a capsule per espresso e cappuccino.",
        Price = 99.99M,
        ImageUrl = "url/to/image/nespresso.jpg"
    },
    new Product
    {
        Id = 13,
        Name = "Portatile Apple MacBook Air 13''",
        Description = "Computer portatile leggero e potente con chip M1 e display Retina.",
        Price = 999.00M,
        ImageUrl = "url/to/image/macbook.jpg"
    },
    new Product
    {
        Id = 14,
        Name = "Profumo Dior Sauvage 100ml",
        Description = "Fragranza fresca e avvolgente, ideale per l'uomo moderno.",
        Price = 85.00M,
        ImageUrl = "url/to/image/dior.jpg"
    },
    new Product
    {
        Id = 15,
        Name = "Occhiali da sole Ray-Ban Aviator",
        Description = "Occhiali da sole classici con montatura in metallo e lenti protettive.",
        Price = 142.00M,
        ImageUrl = "url/to/image/rayban.jpg"
    },
    new Product
    {
        Id = 16,
        Name = "Set di pentole Tefal",
        Description = "Set di pentole antiaderenti in alluminio, ideali per ogni tipo di cottura.",
        Price = 79.99M,
        ImageUrl = "url/to/image/tefal.jpg"
    },
    new Product
    {
        Id = 17,
        Name = "Lampada da tavolo Philips Hue",
        Description = "Lampada intelligente controllabile tramite app, con milioni di colori disponibili.",
        Price = 89.99M,
        ImageUrl = "url/to/image/lampada.jpg"
    },
    new Product
    {
        Id = 18,
        Name = "Sneakers Adidas Stan Smith",
        Description = "Scarpe da ginnastica in pelle bianca con dettagli verdi, ideali per ogni occasione.",
        Price = 94.99M,
        ImageUrl = "url/to/image/adidas.jpg"
    },
    new Product
    {
        Id = 19,
        Name = "Tastiera meccanica Corsair",
        Description = "Tastiera da gaming retroilluminata, con switch meccanici per una risposta rapida.",
        Price = 129.00M,
        ImageUrl = "url/to/image/tastiera.jpg"
    },
    new Product
    {
        Id = 20,
        Name = "Bici da corsa Bianchi",
        Description = "Bicicletta da strada leggera e aerodinamica, ideale per le lunghe distanze.",
        Price = 1499.99M,
        ImageUrl = "url/to/image/bici.jpg"
    }

            };
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int productId;
                if (int.TryParse(button.CommandArgument, out productId))
                {
                    Product productToAdd = GetProductById(productId);

                    if (productToAdd != null)
                    {
                        Cart.Products.Add(productToAdd);
                    }
                }
            }
            Response.Redirect(Request.RawUrl);
        }


        private Product GetProductById(int productId)
        {
            List<Product> products = GetSampleProducts();
            return products.Find(p => p.Id == productId);
        }
        protected void btnGoToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx"); 
        }
        private void UpdateProductCount()
        {
            int productCount = Cart.Products.Count;
            lblProductCount.Text = productCount.ToString();
        }
        protected void btnViewDetails_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            int productId = Convert.ToInt32(btn.CommandArgument);

           
            Response.Redirect($"Details.aspx?ProductId={productId}");
        }
    }
}

