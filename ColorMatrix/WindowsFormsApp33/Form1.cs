using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        float a11, a12, a13, a14, a15, a21, a22, a23, a24, a25, a31, a32, a33, a34, a35, a41, a42, a43, a44, a45, a51, a52, a53, a54, a55;
        

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.333f; a12 = 0.333f; a13 = 0.333f; a14 = 0; a15 = 0;
            a21 = 0.333f; a22 = 0.333f; a23 = 0.333f; a24 = 0; a25 = 0;
            a31 = 0.333f; a32 = 0.333f; a33 = 0.333f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void blackWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            a11 = 0.299f; a12 = 0.299f; a13 = 0.299f; a14 = 0; a15 = 0;
            a21 = 0.587f; a22 = 0.587f; a23 = 0.587f; a24 = 0; a25 = 0;
            a31 = 0.114f; a32 = 0.114f; a33 = 0.114f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = .393f; a12 = .349f; a13 = .272f; a14 = 0; a15 = 0;
            a21 = .769f; a22 = .686f; a23 = .534f; a24 = 0; a25 = 0;
            a31 = .189f; a32 = .168f; a33 = .131f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void skyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.707f; a12 = 0.307f; a13 = 0.707f; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void purpureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.307f; a12 = 0.307f; a13 = 0.307f; a14 = 0; a15 = 0;
            a21 = 0.811f; a22 = 0.811f; a23 = 0.811f; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void purpureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a11 = 0.707f; a12 = 0.307f; a13 = 0.707f; a14 = 0; a15 = 0;
            a21 = 0.811f; a22 = 0.811f; a23 = 0.811f; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void l1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.307f; a52 = 0.407f; a53 = 0.607f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void l2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.507f; a52 = 0.307f; a53 = 0.507f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void l3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.807f; a52 = 0.307f; a53 = 0.607f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void l4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.807f; a52 = 0.607f; a53 = 0.607f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void l5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.207f; a52 = 0.607f; a53 = 0.707f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void l6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0.707f; a52 = 0.507f; a53 = 0.607f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void transparencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 0.3f; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = .3f; a12 = .3f; a13 = .3f; a14 = 0; a15 = 0;
            a21 = .59f; a22 = .59f; a23 = .59f; a24 = 0; a25 = 0;
            a31 = .11f; a32 = .11f; a33 = .11f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 0.3f; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = .393f; a12 = .349f; a13 = .272f; a14 = 0; a15 = 0;
            a21 = .769f; a22 = .686f; a23 = .534f; a24 = 0; a25 = 0;
            a31 = .189f; a32 = .168f; a33 = .131f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 0.3f; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = -1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = -1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 0.3f; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void negativeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a11 = -1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = -1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = -1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 1; a52 = 1; a53 = 1; a54 = 1; a55 = 1;

            colormatrix();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.000789f; a12 = 0.006581f; a13 = 0.013347f; a14 = 0.006581f; a15 = 0.000789f;
            a21 = 0.006581f; a22 = 0.054901f; a23 = 0.111345f; a24 = 0.054901f; a25 = 0.006581f;
            a31 = 0.013347f; a32 = 0.111345f; a33 = 0.225821f; a34 = 0.111345f; a35 = 0.013347f;
            a41 = 0.006581f; a42 = 0.054901f; a43 = 0.111345f; a44 = 0.054901f; a45 = 0.006581f;
            a51 = 0.000789f; a52 = 0.006581f; a53 = 0.013347f; a54 = 0.006581f; a55 = 0.000789f;

            colormatrix();

            
        }

        private void definitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0; a12 = 0; a13 = 1; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 1; a24 = 1; a25 = 0;
            a31 = 1; a32 = 1; a33 = 1; a34 = 1; a35 = 1;
            a41 = 0; a42=  1; a43 = 1; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 1; a54 = 0; a55 = 0;

            colormatrix();
        }

        private void cIED50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 2.27f; a12 = -1.42f; a13 = 0.15f; a14 = 0; a15 = 0;
            a21 =-0.28f; a22 = 1.67f; a23 =-0.39f; a24 = 0; a25 = 0;
            a31 = 0.04f; a32 =-0.08f; a33 = 1.75f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = .2f; a52 = .2f; a53 = .2f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 2.27f; a12 = -1.37f; a13 = 0.10f; a14 = 0; a15 = 0;
            a21 = -0.28f; a22 = 1.65f; a23 = -0.37f; a24 = 0; a25 = 0;
            a31 = 0.06f; a32 = -0.93f; a33 = 1.86f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = .2f; a52 = .2f; a53 = .2f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 3.2410f; a12 = -1.53374f; a13 = -0.4986f; a14 = 0; a15 = 0;
            a21 = -0.9692f; a22 = 1.8760f; a23 = 0.0416f; a24 = 0; a25 = 0;
            a31 = 0.0556f; a32 = -0.2040f; a33 = 1.0570f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void earchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.4124f; a12 = 0.3576f; a13 = 0.1805f; a14 = 0; a15 = 0;
            a21 = 0.2126f; a22 = 0.7152f; a23 = 0.0722f; a24 = 0; a25 = 0;
            a31 = 0.0193f; a32 = 0.1192f; a33 = 0.9505f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void ultravioletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.1202f; a12 = 0.0931f; a13 = 0.0697f; a14 = 0; a15 = 0;
            a21 = 0.1188f; a22 = 0.0917f; a23 = 0.0696f; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void moonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.1202f; a12 = 0.0931f; a13 = 0.0697f; a14 = 0; a15 = 0;
            a21 = 0.1188f; a22 = 0.0917f; a23 = 0.0696f; a24 = 0; a25 = 0;
            a31 = 0.1195f; a32 = 0.0924f; a33 = 0.0697f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void ultraGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.682194521f; a12 = -0.078686986f; a13 = -0.089214041f; a14 = 0; a15 = 0;
            a21 = -0.415894521f; a22 = 1.220428082f; a23 =   0.21884589f; a24 = 0; a25 = 0;
            a31 = -0.080532192f; a32 = 0.200056507f; a33 =  0.581811301f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 3.240454836f; a12 = -1.53713885f; a13 = -0.498531547f; a14 = 0; a15 = 0;
            a21 = -0.96926639f; a22 = 1.876010929f; a23 =  0.041556082f; a24 = 0; a25 = 0;
            a31 =  0.05564342f; a32 =-0.204025854f; a33 =  1.057225162f; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://i.yapx.ru/HqOrk.jpg");
        
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 2; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = .2f; a52 = .2f; a53 = .2f; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void litePinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0.5f; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.124f; a12 = 0.252f; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0.124f; a22 = 0.252f; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0.124f; a32 = 0.252f; a33 = 0; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void liteGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0.607f; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0.5f; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0.5f; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0.607f; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void liteBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 1; a12 = 0; a13 = 0; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0.707f; a24 = 0; a25 = 0;
            a31 = 0.5f; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a11 = 0.307f; a12 = 0.307f; a13 = 0.307f; a14 = 0; a15 = 0;
            a21 = 0; a22 = 1; a23 = 0; a24 = 0; a25 = 0;
            a31 = 0; a32 = 0; a33 = 1; a34 = 0; a35 = 0;
            a41 = 0; a42 = 0; a43 = 0; a44 = 1; a45 = 0;
            a51 = 0; a52 = 0; a53 = 0; a54 = 0; a55 = 1;

            colormatrix();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        

        public Form1()
        {
            InitializeComponent();
            

        }

        public void colormatrix()
        {
        Graphics graf = pictureBox1.CreateGraphics();
        Image image = pictureBox1.Image;
        int wid = image.Width;
        int hgt = image.Height;
        Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                Color[] color =
                {
                     Color.Red, Color.OrangeRed, Color.Yellow,
            Color.Green, Color.Blue, Color.Indigo,
            Color.Fuchsia,
                };
    const float scale = 2.0f;

                for (int i = 0; i<color.Length; i++)
                {
                    System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix(new float[][]
            {
                new float[] { a11, a12, a13, a14, a15 },
                new float[] { a21, a22, a23, a24, a25 },
                new float[] { a31, a32, a33, a34, a35 },
                new float[] { a41, a42, a43, a44, a45 },
                new float[] { a51, a52, a53, a54, a55 }
            });

    System.Drawing.Imaging.ImageAttributes attr = new System.Drawing.Imaging.ImageAttributes();
    attr.SetColorMatrix(cm);
                    int x = (int)(i * image.Width / color.Length);
    Point[] points =
{
                new Point(x, 0),
                new Point(wid, 0),
                new Point(x, hgt),
            };

    Rectangle rect = new Rectangle(x, 0, wid - x, hgt);
    gr.DrawImage(image, points, rect,
        GraphicsUnit.Pixel, attr);
                }
            }
            pictureBox1.Image = bm;



}
       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
              
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ColorMatrix  1.0\n\n\n© 2020 Ramunis Soft", "Information");
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://ramunisoft.blogspot.com/");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как...";
            //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
            savedialog.OverwritePrompt = true;
            //отображать ли предупреждение, если пользователь указывает несуществующий путь
            savedialog.CheckPathExists = true;
            //список форматов файла, отображаемый в поле "Тип файла"
            savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            //отображается ли кнопка "Справка" в диалоговом окне
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
            {
                try
                {
                    pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            a11 = float.Parse(textBox1.Text); a12 = float.Parse(textBox2.Text); a13 = float.Parse(textBox3.Text); a14 = float.Parse(textBox4.Text); a15 = float.Parse(textBox5.Text);
            a21 = float.Parse(textBox6.Text); a22 = float.Parse(textBox7.Text); a23 = float.Parse(textBox8.Text); a24 = float.Parse(textBox9.Text); a25 = float.Parse(textBox10.Text);
            a31 = float.Parse(textBox11.Text);a32 = float.Parse(textBox12.Text);a33 = float.Parse(textBox13.Text);a34 = float.Parse(textBox14.Text);a35 = float.Parse(textBox15.Text);
            a41 = float.Parse(textBox16.Text);a42 =float.Parse(textBox17.Text); a43 = float.Parse(textBox18.Text);a44 = float.Parse(textBox19.Text);a45 = float.Parse(textBox20.Text);
            a51 = float.Parse(textBox21.Text); a52 =float.Parse(textBox22.Text); a53 =float.Parse(textBox23.Text); a54 =float.Parse(textBox24.Text); a55 =float.Parse(textBox25.Text);

            colormatrix();
        }
    }
}
