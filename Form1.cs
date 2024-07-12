using System;
using System.Drawing;
using System.Windows.Forms;

namespace Food_Apllication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();   
     
        }

        /// <summary>
        /// Foods ボタンクリックされる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoods_Click(object sender, EventArgs e)
        {
           
            //Foodsボタンに対応するアイコンを表示する処理
            pnlOnButtonFoods.Height = btnFoods.Height;      //ボタンの高さに合わせてアイコンの高さを設定する
            pnlOnButtonFoods.Top = btnFoods.Top;            //ボタンの位置に合わせてアイコンの位置を設定する
            
            //Foodsボタンに対応するアイコンを表示する
            pnlOnButtonFoods.Visible = true;
            //他のボタンの関連するアイコンパネルを非表示する
            pnlOnButtonDrinks.Visible = false;
            pnlOnButtonDesserts.Visible = false;
            pnlOnButtonMyCart.Visible = false;
            pnlOnButtonAbout.Visible = false;

            //Foodsボタンに対応するコンテンツを表示し、他を非表示する
            pnlFoods.Visible = true;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlMyCart.Visible = false; 
            pnlAboutUs.Visible = false;
        }

        //Drinksボタンがクリックされた時の処理
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //Drinksボタンの高さと位置に合わせてアイコンを設定する
            pnlOnButtonDrinks.Height = btnDrinks.Height;        
            pnlOnButtonDrinks.Top = btnDrinks.Top;
            //Drinksボタンに対応するパネルを表示し、他を日表示する
            pnlOnButtonFoods.Visible = false;
            pnlOnButtonDrinks.Visible = true;
            pnlOnButtonDesserts.Visible = false;
            pnlOnButtonMyCart.Visible = false;
            pnlOnButtonAbout.Visible = false;

            //Drinksボタンに対応するコンテンツを表示し、他を非表示する
            pnlFoods.Visible = false;
            pnlDrinks.Visible = true;
            pnlDesserts.Visible = false;
            pnlMyCart.Visible = false;
            pnlAboutUs.Visible = false;
        }

        //Dessertsボタンがクリックされた時の処理
        private void btnDesserts_Click(object sender, EventArgs e)
        {
            //Dessertsボタンの高さと位置に合わせてアイコンを設定する
            pnlOnButtonDesserts.Height = btnDesserts.Height;
            pnlOnButtonDesserts.Top = btnDesserts.Top;
            //Dessertsボタンに対応するパネルを表示し、他を日表示する
            pnlOnButtonFoods.Visible = false;
            pnlOnButtonDrinks.Visible = false;
            pnlOnButtonDesserts.Visible = true;
            pnlOnButtonMyCart.Visible = false;
            pnlOnButtonAbout.Visible = false;

            //Dessertsボタンに対応するコンテンツを表示し、他を非表示する
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = true;
            pnlMyCart.Visible = false;
            pnlAboutUs.Visible = false;
        }

        //My Cartボタンをクリックされた場合の処理
        private void btnMyCart_Click(object sender, EventArgs e)
        {
            //My Cartボタンの高さを位置に合わせてアイコンを設定する
            pnlOnButtonMyCart.Height = btnMyCart.Height;
            pnlOnButtonMyCart.Top = btnMyCart.Top;
            //My Cartボタンに対応するアイコンパネルを表示し、他を非表示する
            pnlOnButtonFoods.Visible = false;
            pnlOnButtonDrinks.Visible = false;
            pnlOnButtonDesserts.Visible = false;
            pnlOnButtonMyCart.Visible = true;
            pnlOnButtonAbout.Visible = false;

            //My Cartボタンに対応するコンテンツを表示し、他を非表示する
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlMyCart.Visible = true;
            pnlAboutUs.Visible = false;
        }

        //About ボタンをクリックされた時の処理
        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Aboutボタンの高さと位置に合わせてアイコンを設定する
            pnlOnButtonAbout.Height = btnAbout.Height;
            pnlOnButtonAbout.Top = btnAbout.Top;
            //About ボタンに対応するアイコンパネルを表示し、他を非表示する
            pnlOnButtonFoods.Visible = false;
            pnlOnButtonDrinks.Visible = false;
            pnlOnButtonDesserts.Visible = false;
            pnlOnButtonMyCart.Visible = false;
            pnlOnButtonAbout.Visible = true;

            //Aboutボタンに対応するアイコンパネルを表示し、他を非表示する
            pnlFoods.Visible = false;
            pnlDrinks.Visible = false;
            pnlDesserts.Visible = false;
            pnlMyCart.Visible = false;
            pnlAboutUs.Visible = true;
        }

        //Closeアイコンがクリックされる時の処理
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();         //アプリケーションを終了する
        }

        //最初化するアイコンがクリックされた時の処理
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       //ウインドウの状態を最小化に設定する
        }

        //最大化するアイコンがクリックされた時の処理
        private void picMaximize_Click(object sender, EventArgs e)
        {
            //ウインドウの状態が通常の場合
            if (this.WindowState == FormWindowState.Normal)
            {
                //ウインドウを最大化する
                this.WindowState = FormWindowState.Maximized;
            }
            //ウインドウの状態が最大化されている場合
            else if (this.WindowState == FormWindowState.Maximized)
            {
                //ウインドウを通常サイズに戻す
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
