﻿
namespace JobTestStringParser
{
     partial class Form1
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.buttonParse = new System.Windows.Forms.Button();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonParse
               // 
               this.buttonParse.Location = new System.Drawing.Point(584, 180);
               this.buttonParse.Name = "buttonParse";
               this.buttonParse.Size = new System.Drawing.Size(75, 23);
               this.buttonParse.TabIndex = 1;
               this.buttonParse.Text = "Parse Data";
               this.buttonParse.UseVisualStyleBackColor = true;
               this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(12, 12);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowTemplate.Height = 25;
               this.dataGridView1.Size = new System.Drawing.Size(647, 150);
               this.dataGridView1.TabIndex = 2;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.buttonParse);
               this.Name = "Form1";
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.Button buttonParse;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.BindingSource bindingSource1;
     }
}

