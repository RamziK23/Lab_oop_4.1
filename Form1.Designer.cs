namespace Lab_oop_4._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_show = new System.Windows.Forms.Button();
            this.button_deletestorage = new System.Windows.Forms.Button();
            this.button_clear_paintbox = new System.Windows.Forms.Button();
            this.button_del__item_storage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(647, 22);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(106, 35);
            this.button_show.TabIndex = 0;
            this.button_show.Text = "button_show";
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_deletestorage
            // 
            this.button_deletestorage.Location = new System.Drawing.Point(647, 61);
            this.button_deletestorage.Name = "button_deletestorage";
            this.button_deletestorage.Size = new System.Drawing.Size(106, 35);
            this.button_deletestorage.TabIndex = 1;
            this.button_deletestorage.Text = "button_deletestorage";
            this.button_deletestorage.UseVisualStyleBackColor = true;
            this.button_deletestorage.Click += new System.EventHandler(this.button_deletestorage_Click);
            // 
            // button_clear_paintbox
            // 
            this.button_clear_paintbox.Location = new System.Drawing.Point(647, 143);
            this.button_clear_paintbox.Name = "button_clear_paintbox";
            this.button_clear_paintbox.Size = new System.Drawing.Size(106, 35);
            this.button_clear_paintbox.TabIndex = 3;
            this.button_clear_paintbox.Text = "button_clear_paintbox";
            this.button_clear_paintbox.UseVisualStyleBackColor = true;
            this.button_clear_paintbox.Click += new System.EventHandler(this.button_clear_paintbox_Click);
            // 
            // button_del__item_storage
            // 
            this.button_del__item_storage.Location = new System.Drawing.Point(647, 102);
            this.button_del__item_storage.Name = "button_del__item_storage";
            this.button_del__item_storage.Size = new System.Drawing.Size(106, 35);
            this.button_del__item_storage.TabIndex = 4;
            this.button_del__item_storage.Text = "button_del__item_storage";
            this.button_del__item_storage.UseVisualStyleBackColor = true;
            this.button_del__item_storage.Click += new System.EventHandler(this.button_del__item_storage_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 426);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear_paintbox);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_deletestorage);
            this.Controls.Add(this.button_del__item_storage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_deletestorage;
        private System.Windows.Forms.Button button_clear_paintbox;
        private System.Windows.Forms.Button button_del__item_storage;
        private System.Windows.Forms.Panel panel1;
    }
}

